﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Library.Data.Entities.Models;
using Library.Data.Enums;
using Library.Domain.Repositories;

namespace Library.Presentation.Forms.AddForms
{
    public partial class AddBorrowEventForm : Form
    {
        private StudentRepository _studentRepository;
        private BookRepository _bookRepository;
        private BookCopyRepository _bookCopyRepository;
        private BorrowEventRepository _borrowEventRepository;

        public AddBorrowEventForm()
        {
            _studentRepository = new StudentRepository();
            _bookRepository = new BookRepository();
            _bookCopyRepository = new BookCopyRepository();
            _borrowEventRepository = new BorrowEventRepository();
            InitializeComponent();
            LoadStudentComboBox();
            DateOfRentPicker.MaxDate = DateTime.Now.Date;
        }

        private void RefreshBooksListBox()
        {
            _studentRepository = new StudentRepository();
            _bookRepository = new BookRepository();
            _bookCopyRepository = new BookCopyRepository();
            _borrowEventRepository = new BorrowEventRepository();
            BooksListBox.Items.Clear();

            var studentBooksBorrowed = _borrowEventRepository.GetBorrowEventsByStudent(StudentComboBox.Text).ToList();

            var readOnlyBookCopies =
                _bookCopyRepository.GetAllBookCopies().Where(bookCopy => bookCopy.Status == BookStatus.ReadOnly)
                    .GroupBy(bookCopy => bookCopy.Book.ToString()).ToList();

            var readOnlyBooks = new List<Book>();

            foreach (var bookCopy in readOnlyBookCopies)
            {
                readOnlyBooks.Add(_bookRepository.GetAllBooks().First(book => book.ToString() == bookCopy.Key));
            }

            foreach (var book in _bookRepository.GetAllBooks().OrderBy(book => book.Name).ThenBy(book => book.Publisher.ToString()))
            {
                if (studentBooksBorrowed.Any(borrowEvent => borrowEvent.BookCopy.Book.ToString() == book.ToString()) 
                    || readOnlyBooks.Contains(book))
                    continue;
                BooksListBox.Items.Add(book);
            }
        }

        private void LoadStudentComboBox()
        {
            StudentComboBox.Items.Clear();
            StudentComboBox.Text = "";
            foreach (var student in _studentRepository.GetAllStudents())
            {
                StudentComboBox.Items.Add(student);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CheckForErrors())
            {
                var fieldsError = new ErrorForm("You are missing some required fields!");
                fieldsError.ShowDialog();
                return;
            }
            
            var studentToAdd = _studentRepository.GetAllStudents()
                .FirstOrDefault(student => student.ToString() == StudentComboBox.Text);

            foreach (var checkedItem in BooksListBox.CheckedItems)
            {
                var bookToAdd = _bookRepository.GetAllBooks()
                    .FirstOrDefault(book => book.ToString() == checkedItem.ToString());
                var isAvailable = _bookRepository.IsBookAvailable(bookToAdd);

                if (!isAvailable)
                {
                    var copiesError = new ErrorForm($"There are no available copies of {bookToAdd}!");
                    copiesError.ShowDialog();
                    continue;
                }

                var bookCopyToAdd = _bookCopyRepository.GetAllBookCopies().First(bookCopy =>
                    bookCopy.Book.ToString() == checkedItem.ToString()
                    && bookCopy.Status == BookStatus.Available);

                var eventToAdd = new BorrowEvent(DateOfRentPicker.Value, null, studentToAdd, bookCopyToAdd);
                _borrowEventRepository.AddBorrowEvent(eventToAdd);
            }
            LoadStudentComboBox();
            BooksListBox.Items.Clear();
        }

        private bool CheckForErrors()
        {
            return (string.IsNullOrWhiteSpace(StudentComboBox.Text) || BooksListBox.CheckedItems.Count == 0);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshBooksListBox();
        }
    }
}
