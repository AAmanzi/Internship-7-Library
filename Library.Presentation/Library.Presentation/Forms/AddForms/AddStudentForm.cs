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
        private readonly StudentRepository _studentRepository;
        public AddStudentForm()
        {
            _studentRepository = new StudentRepository();
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
                var fieldsError = new ErrorForm("You are missing some required fields!");
                fieldsError.ShowDialog();
                return;
            }

            var toAdd = new Student(NameTextBox.Text, LastNameTextBox.Text, DateOfBirthPicker.Value,
                (Sex) Enum.Parse(typeof(Sex), SexComboBox.Text),
                (SchoolClass) Enum.Parse(typeof(SchoolClass), ClassComboBox.Text));

            _studentRepository.AddStudent(toAdd);
            Close();
        }

        private bool CheckForErrors()
        {
            return (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(LastNameTextBox.Text)
                    || string.IsNullOrWhiteSpace(SexComboBox.Text) || string.IsNullOrWhiteSpace(ClassComboBox.Text));
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void LastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
    }
}
