﻿using System;
using System.Linq;
using System.Windows.Forms;
using Library.Data.Entities.Models;
using Library.Data.Enums;
using Library.Domain.Repositories;
using Library.Infrastructure.Extensions;

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
            DateOfBirthPicker.Value = DateTime.Now.Subtract(new TimeSpan(365 * 10 + 2, 0, 0, 0));
            DateOfBirthPicker.MaxDate = DateTime.Now.Subtract(new TimeSpan(365 * 5 + 1, 0, 0, 0));
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
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = NameTextBox.Text.TrimAndRemoveWhiteSpaces().AllFirstLettersToUpper();
            LastNameTextBox.Text = LastNameTextBox.Text.TrimAndRemoveWhiteSpaces().AllFirstLettersToUpper();

            if (!CheckForErrors())
                return;

            var toAdd = new Student(NameTextBox.Text, LastNameTextBox.Text, DateOfBirthPicker.Value,
                (Sex) Enum.Parse(typeof(Sex), SexComboBox.Text),
                (SchoolClass) Enum.Parse(typeof(SchoolClass), ClassComboBox.Text));

            _studentRepository.AddStudent(toAdd);
            Close();
        }

        private bool CheckForErrors()
        {
            if ((string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(LastNameTextBox.Text)
                                                             || string.IsNullOrWhiteSpace(SexComboBox.Text) ||
                                                             string.IsNullOrWhiteSpace(ClassComboBox.Text)))
            {
                var fieldsError = new ErrorForm("You are missing some required fields!");
                fieldsError.ShowDialog();
                return false;
            }

            if (_studentRepository.GetAllStudents().FirstOrDefault(student =>
                    student.Name == NameTextBox.Text && student.LastName == LastNameTextBox.Text &&
                    student.SchoolClass == (SchoolClass) Enum.Parse(typeof(SchoolClass), ClassComboBox.Text)) ==
                null) return true;
            var existingStudent = new ErrorForm("That student already exists!");
            existingStudent.ShowDialog();
            return false;
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
