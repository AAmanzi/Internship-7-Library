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
using Library.Domain.Repositories;

namespace Library.Presentation.Forms
{
    public partial class ReturnBorrowEventForm : Form
    {
        private readonly StudentRepository _studentRepository;
        private readonly BorrowEventRepository _borrowEventRepository;
        public ReturnBorrowEventForm()
        {
            _studentRepository = new StudentRepository();
            _borrowEventRepository = new BorrowEventRepository();
            InitializeComponent();
            LoadStudentTextBox();
        }

        private void LoadStudentTextBox()
        {
            foreach (var student in _studentRepository.GetAllStudents())
            {
                StudentComboBox.Items.Add(student);
            }
        }

        private void StudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshStudentRentInfo();
        }

        private void RefreshStudentRentInfo()
        {
            DateOfRentTextBox.Text = "";
            BooksListBox.Items.Clear();
            var studentBorrowEvents = _borrowEventRepository.GetBorrowEventsByStudent(StudentComboBox.Text);
            foreach (var borrowEvent in studentBorrowEvents)
            {
                BooksListBox.Items.Add(borrowEvent.BookCopy.Book);
            }
        }

        private void BooksListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (var ix = 0; ix < BooksListBox.Items.Count; ++ix)
                if (ix != e.Index) BooksListBox.SetItemChecked(ix, false);
            RefreshDateOfBorrowTextBox();
        }

        private void RefreshDateOfBorrowTextBox()
        {
            var selected = BooksListBox.SelectedItem.ToString();
            var checkedBorrowEvent = _borrowEventRepository.GetAllBorrowEvents().FirstOrDefault(borrowEvent =>
                borrowEvent.Student.ToString() == StudentComboBox.Text &&
                borrowEvent.BookCopy.Book.ToString() == selected);
            DateOfRentTextBox.Text = $"{checkedBorrowEvent.DateOfBorrow :dd MMMM yyyy}";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CheckForErrors())
            {
                var fieldsError = new ErrorForm("You are missing some required fields!");
                fieldsError.ShowDialog();
                return;
            }
            var selected = BooksListBox.SelectedItem.ToString();
            var checkedBorrowEvent = _borrowEventRepository.GetAllBorrowEvents().FirstOrDefault(borrowEvent =>
                borrowEvent.Student.ToString() == StudentComboBox.Text &&
                borrowEvent.BookCopy.Book.ToString() == selected);

            _borrowEventRepository.ReturnBookEvent(checkedBorrowEvent, DateOfReturnPicker.Value);
        }

        private bool CheckForErrors()
        {
            return (string.IsNullOrWhiteSpace(StudentComboBox.Text) ||
                    string.IsNullOrWhiteSpace(BooksListBox.SelectedItem.ToString()) ||
                    string.IsNullOrWhiteSpace(DateOfRentTextBox.Text));
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
