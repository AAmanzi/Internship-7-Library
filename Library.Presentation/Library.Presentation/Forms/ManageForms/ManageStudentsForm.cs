using System;
using System.Linq;
using System.Windows.Forms;
using Library.Domain.Repositories;
using Library.Presentation.Forms.AddForms;
using Library.Presentation.Forms.EditForms;

namespace Library.Presentation.Forms.ManageForms
{
    public partial class ManageStudentsForm : Form
    {
        private StudentRepository _studentRepository;
        private BorrowEventRepository _borrowEventRepository;
        public ManageStudentsForm()
        {
            InitializeComponent();
            RefreshStudentsListBox();
        }

        private void RefreshStudentsListBox()
        {
            _studentRepository = new StudentRepository();
            _borrowEventRepository = new BorrowEventRepository();
            StudentsListBox.Items.Clear();
            foreach (var student in _studentRepository.GetAllStudents().OrderBy(student => student.LastName).ThenBy(student => student.Name))
            {
                StudentsListBox.Items.Add(student.ToString());
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addStudent = new AddStudentForm();
            addStudent.ShowDialog();
            RefreshStudentsListBox();
        }

        private void StudentsListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (var ix = 0; ix < StudentsListBox.Items.Count; ++ix)
                if (ix != e.Index) StudentsListBox.SetItemChecked(ix, false);
            RefreshStudentInfoListBox();
        }

        private void RefreshStudentInfoListBox()
        {
            StudentInfoListBox.Items.Clear();
            var selected = StudentsListBox.SelectedItem.ToString();
            var checkedStudent = _studentRepository.GetAllStudents()
                .FirstOrDefault(student => student.ToString() == selected);

            if (checkedStudent == null)
                return;
            StudentInfoListBox.Items.Add($"Date of birth");
            StudentInfoListBox.Items.Add($"{checkedStudent.DateOfBirth :   dd-mm-yyyy}");
            StudentInfoListBox.Items.Add($"{checkedStudent.Sex}");

            var borrowedBooks = _borrowEventRepository.GetBorrowEventsByStudent(selected);

            if (borrowedBooks.Count != 0)
            {
                StudentInfoListBox.Items.Add($"");
                StudentInfoListBox.Items.Add($"Has books:");
            }

            foreach (var borrowedBook in borrowedBooks)
            {
                StudentInfoListBox.Items.Add($"{borrowedBook.BookCopy.Book}");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!IsSafeToDelete())
                return;

            var selected = StudentsListBox.SelectedItem.ToString();
            var checkedAuthor = _studentRepository.GetAllStudents()
                .FirstOrDefault(author => author.ToString() == selected);

            _studentRepository.TryDelete(checkedAuthor);
            RefreshStudentsListBox();
            StudentInfoListBox.Items.Clear();
        }

        private bool IsSafeToDelete()
        {
            if (StudentsListBox.SelectedItem == null)
                return false;

            var selected = StudentsListBox.SelectedItem.ToString();

            if (_borrowEventRepository.GetBorrowEventsByStudent(selected).Count != 0)
            {
                var bookError = new ErrorForm("The selected student must first return all borrowed books before deletion!");
                bookError.ShowDialog();
                return false;
            }

            var confirmCancel = new ConfirmForm();
            confirmCancel.ShowDialog();
            return confirmCancel.IsConfirmed;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (StudentsListBox.CheckedItems.Count == 0)
                return;

            var selected = StudentsListBox.SelectedItem.ToString();

            var editSelectedStudent = new EditStudentForm(selected);
            editSelectedStudent.ShowDialog();
            RefreshStudentsListBox();
            StudentInfoListBox.Items.Clear();
        }
    }
}
