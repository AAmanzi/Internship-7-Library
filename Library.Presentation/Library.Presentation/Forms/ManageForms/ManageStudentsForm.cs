using System;
using System.Linq;
using System.Windows.Forms;
using Library.Domain.Repositories;
using Library.Presentation.Forms.AddForms;

namespace Library.Presentation.Forms.ManageForms
{
    public partial class ManageStudentsForm : Form
    {
        private StudentRepository _allStudents;
        public ManageStudentsForm()
        {
            InitializeComponent();
            RefreshStudentsListBox();
        }

        private void RefreshStudentsListBox()
        {
            _allStudents = new StudentRepository();
            StudentsListBox.Items.Clear();
            foreach (var student in _allStudents.GetAllStudents().OrderBy(student => student.LastName).ThenBy(student => student.Name))
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
            var checkedStudent = _allStudents.GetAllStudents()
                .FirstOrDefault(student => student.ToString() == selected);

            if (checkedStudent == null)
                return;
            StudentInfoListBox.Items.Add($"Date of birth");
            StudentInfoListBox.Items.Add($"{checkedStudent.DateOfBirth :   dd-mm-yyyy}");
            StudentInfoListBox.Items.Add($"{checkedStudent.Sex}");
        }
    }
}
