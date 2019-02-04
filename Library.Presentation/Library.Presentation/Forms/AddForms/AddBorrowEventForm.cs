using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Data.Entities.Models;
using Library.Data.Enums;
using Library.Domain.Repositories;

namespace Library.Presentation.Forms.AddForms
{
    public partial class AddBorrowEventForm : Form
    {
        private StudentRepository _allStudents;
        private BookRepository _allBooks;
        private BookCopyRepository _allBookCopies;
        private BorrowEventRepository _allBorrowEvents;

        public AddBorrowEventForm()
        {
            _allStudents = new StudentRepository();
            _allBooks = new BookRepository();
            _allBookCopies = new BookCopyRepository();
            _allBorrowEvents = new BorrowEventRepository();
            InitializeComponent();
            RefreshBooksListBox();
            LoadStudentComboBox();
        }

        private void RefreshBooksListBox()
        {
            _allStudents = new StudentRepository();
            _allBooks = new BookRepository();
            _allBookCopies = new BookCopyRepository();
            _allBorrowEvents = new BorrowEventRepository();
            BooksListBox.Items.Clear();
            foreach (var book in _allBooks.GetAllBooks().OrderBy(book => book.Name).ThenBy(book => book.Publisher))
            {
                BooksListBox.Items.Add(book);
            }
        }

        private void LoadStudentComboBox()
        {
            foreach (var student in _allStudents.GetAllStudents())
            {
                StudentComboBox.Items.Add(student);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var confirmCancel = new ConfirmForm();
            confirmCancel.ShowDialog();
            if (confirmCancel.IsConfirmed)
                Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CheckForErrors())
            {
                var fieldsError = new ErrorForm("You are missing some required fields!");
                fieldsError.ShowDialog();
                return;
            }
            
            var studentToAdd = _allStudents.GetAllStudents()
                .FirstOrDefault(student => student.ToString() == StudentComboBox.Text);

            foreach (var checkedItem in BooksListBox.CheckedItems)
            {
                var bookCopyToAdd = _allBookCopies.GetAllBookCopies().First(bookCopy =>
                    bookCopy.Book.ToString() == checkedItem.ToString()
                    && bookCopy.Status == BookStatus.Available);

                if (bookCopyToAdd == null)
                {
                    var copiesError = new ErrorForm("There are no available copies of that book!");
                }

                var eventToAdd = new BorrowEvent(DateOfRentPicker.Value, null, studentToAdd, bookCopyToAdd);
                _allBorrowEvents.AddBorrowEvent(eventToAdd);
            }

        }

        private bool CheckForErrors()
        {
            return (string.IsNullOrWhiteSpace(StudentComboBox.Text) || BooksListBox.CheckedItems.Count == 0);
        }
    }
}
