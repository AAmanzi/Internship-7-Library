using Library.Domain.Repositories;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Library.Presentation.Forms
{
    public partial class ReturnBorrowEventForm : Form
    {
        private readonly StudentRepository _studentRepository;
        private BorrowEventRepository _borrowEventRepository;
        public ReturnBorrowEventForm()
        {
            _studentRepository = new StudentRepository();
            _borrowEventRepository = new BorrowEventRepository();
            InitializeComponent();
            LoadStudentTextBox();
        }

        private void LoadStudentTextBox()
        {
            StudentComboBox.Items.Clear();
            StudentComboBox.Text = "";
            foreach (var student in _studentRepository.GetAllStudents())
            {
                if(_borrowEventRepository.GetBorrowEventsByStudent(student.ToString()).Count != 0)
                    StudentComboBox.Items.Add(student);
            }
        }

        private void StudentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshStudentRentInfo();
        }

        private void RefreshStudentRentInfo()
        {
            _borrowEventRepository = new BorrowEventRepository();
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
            _borrowEventRepository = new BorrowEventRepository();
            var selected = BooksListBox.SelectedItem.ToString();

            var checkedBorrowEvent = _borrowEventRepository.GetAllBorrowEvents().First(borrowEvent =>
                borrowEvent.Student.ToString() == StudentComboBox.Text &&
                borrowEvent.BookCopy.Book.ToString() == selected && borrowEvent.DateOfReturn == null);
            DateOfRentTextBox.Text = $@"{checkedBorrowEvent.DateOfBorrow :dd MMMM yyyy}";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!CheckForErrors())
                return;
            var selected = BooksListBox.SelectedItem.ToString();
            var checkedBorrowEvent = _borrowEventRepository.GetAllBorrowEvents().First(borrowEvent =>
                borrowEvent.Student.ToString() == StudentComboBox.Text &&
                borrowEvent.BookCopy.Book.ToString() == selected && borrowEvent.DateOfReturn == null);

            _borrowEventRepository.ReturnBookEvent(checkedBorrowEvent, DateOfReturnPicker.Value);
            LoadStudentTextBox();
            RefreshStudentRentInfo();
        }

        private bool CheckForErrors()
        {
            if (string.IsNullOrWhiteSpace(StudentComboBox.Text) ||
                string.IsNullOrWhiteSpace(DateOfRentTextBox.Text))
            {
                var fieldsError = new ErrorForm("You are missing some required fields!");
                fieldsError.ShowDialog();
                return false;
            }

            if (string.IsNullOrWhiteSpace(BooksListBox.SelectedItem.ToString()))
            {
                var fieldsError = new ErrorForm("You are missing some required fields!");
                fieldsError.ShowDialog();
                return false;
            }

            if (DateOfReturnPicker.Value >= Convert.ToDateTime(DateOfRentTextBox.Text)) return true;
            var dateError = new ErrorForm("A book cannot be returned before it has been borrowed");
            dateError.ShowDialog();
            return false;
        } 

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
