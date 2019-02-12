using System;
using System.Linq;
using System.Windows.Forms;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;
using Library.Infrastructure.Extensions;

namespace Library.Presentation.Forms.EditForms
{
    public partial class EditAuthorForm : Form
    {
        private readonly AuthorRepository _authorRepository;
        private readonly string _selectedAuthor;
        public EditAuthorForm(string selectedAuthor)
        {
            InitializeComponent();
            _selectedAuthor = selectedAuthor;
            _authorRepository = new AuthorRepository();
            LoadAuthorInfo();
        }

        private void LoadAuthorInfo()
        {
            var authorToUpdate = _authorRepository.GetAllAuthors()
                .First(author => author.ToString() == _selectedAuthor);

            NameTextBox.Text = authorToUpdate.Name;
            LastNameTextBox.Text = authorToUpdate.LastName;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = NameTextBox.Text.TrimAndRemoveWhiteSpaces().AllFirstLettersToUpper();
            LastNameTextBox.Text = LastNameTextBox.Text.TrimAndRemoveWhiteSpaces().AllFirstLettersToUpper();
            if (!CheckForErrors())
                return;

            var authorToUpdate = _authorRepository.GetAllAuthors()
                .First(author => author.ToString() == _selectedAuthor);

            var authorUpdated = new Author(NameTextBox.Text, LastNameTextBox.Text);

            _authorRepository.TryUpdate(authorToUpdate, authorUpdated);
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

            var authorToUpdate = _authorRepository.GetAllAuthors()
                .First(author => author.ToString() == _selectedAuthor);

            if (authorToUpdate.Name == NameTextBox.Text && authorToUpdate.LastName == LastNameTextBox.Text)
            {
                Close();
                return false;
            }

            if (_authorRepository.GetAllAuthors().FirstOrDefault(author =>
                    author.Name == NameTextBox.Text && author.LastName == LastNameTextBox.Text) == null) return true;
            var existingAuthor = new ErrorForm("That author already exists!");
            existingAuthor.ShowDialog();
            return false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '.';
        }

        private void LastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
    }
}
