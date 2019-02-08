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

namespace Library.Presentation.Forms.AddForms
{
    public partial class AddAuthorForm : Form
    {
        private readonly AuthorRepository _authorRepository;
        public AddAuthorForm()
        {
            _authorRepository = new AuthorRepository();
            InitializeComponent();
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
            if (!CheckForErrors())
                return;

            var toAdd = new Author
            {
                Name = NameTextBox.Text,
                LastName = LastNameTextBox.Text
            };

            _authorRepository.AddAuthor(toAdd);
            Close();
        }

        private bool CheckForErrors()
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                var fieldsError = new ErrorForm("You are missing some required fields!");
                fieldsError.ShowDialog();
                return false;
            }

            if (_authorRepository.GetAllAuthors().FirstOrDefault(author =>
                    author.Name == NameTextBox.Text && author.LastName == LastNameTextBox.Text) == null) return true;
            var existingAuthor = new ErrorForm("That author already exists!");
            existingAuthor.ShowDialog();
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
