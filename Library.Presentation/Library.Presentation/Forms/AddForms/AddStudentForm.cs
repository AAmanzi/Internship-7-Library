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
    public partial class AddStudentForm : Form
    {
        private readonly StudentRepository _allStudents;
        public AddStudentForm()
        {
            _allStudents = new StudentRepository();
            InitializeComponent();
            LoadSexComboBox();
            LoadClassComboBox();
        }

        private void LoadSexComboBox()
        {
            var sexTypes = Enum.GetNames(typeof(Sex));
            foreach (var sexType in sexTypes)
            {
                SexComboBox.Items.Add(sexType);
            }
        }

        private void LoadClassComboBox()
        {
            var classTypes = Enum.GetNames(typeof(SchoolClass));
            foreach (var classType in classTypes)
            {
                ClassComboBox.Items.Add(classType);
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
                var fieldsError = new ErrorForm();
                fieldsError.ShowDialog();
                return;
            }

            var toAdd = new Student
            {
                Name = NameTextBox.Text,
                LastName = LastNameTextBox.Text,
                DateOfBirth = DateOfBirthPicker.Value,
                Sex = (Sex)Enum.Parse(typeof(Sex), SexComboBox.Text),
                SchoolClass = (SchoolClass)Enum.Parse(typeof(SchoolClass), ClassComboBox.Text)
            };

            _allStudents.AddStudent(toAdd);
            Close();
        }

        private bool CheckForErrors()
        {
            return (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(LastNameTextBox.Text)
                    || string.IsNullOrWhiteSpace(SexComboBox.Text) || string.IsNullOrWhiteSpace(ClassComboBox.Text));
        }
    }
}
