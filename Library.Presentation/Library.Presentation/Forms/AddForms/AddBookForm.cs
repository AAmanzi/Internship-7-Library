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
using Library.Infrastructure.Extensions;

namespace Library.Presentation.Forms.AddForms
{
    public partial class AddBookForm : Form
    {
        private readonly BookRepository _bookRepository;
        private readonly AuthorRepository _authorRepository;
        private readonly PublisherRepository _publisherRepository;
        private readonly BookCopyRepository _bookCopyRepository;
        public AddBookForm()
        {
            _bookRepository = new BookRepository();
            _authorRepository = new AuthorRepository();
            _publisherRepository = new PublisherRepository();
            _bookCopyRepository = new BookCopyRepository();
            InitializeComponent();
            LoadGenreComboBox();
            LoadAuthorComboBox();
            LoadPublisherComboBox();
        }

        private void LoadGenreComboBox()
        {
            var genreTypes = Enum.GetNames(typeof(Genre));
            foreach (var genreType in genreTypes)
            {
                GenreComboBox.Items.Add(genreType);
            }
        }

        private void LoadAuthorComboBox()
        {
            foreach (var author in _authorRepository.GetAllAuthors())
            {
                AuthorComboBox.Items.Add($"{author}");
            }
        }

        private void LoadPublisherComboBox()
        {
            foreach (var publisher in _publisherRepository.GetAllPublishers())
            {
                PublisherComboBox.Items.Add($"{publisher}");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = NameTextBox.Text.TrimAndRemoveWhiteSpaces();
            if (!CheckForErrors())
                return;

            var toAdd = new Book
            {
                Name = NameTextBox.Text,
                PageCount = PageCountTextBox.Text,
                Genre = (Genre)Enum.Parse(typeof(Genre), GenreComboBox.Text),
                Author = _authorRepository.GetAllAuthors().First(author => author.ToString() == AuthorComboBox.Text),
                Publisher = _publisherRepository.GetAllPublishers().First(publisher => publisher.ToString() == PublisherComboBox.Text)
            };

            _bookRepository.AddBook(toAdd);

            var statusToAdd = IsReadOnlyCheckBox.Checked ? BookStatus.ReadOnly : BookStatus.Available;

            for (var i = 0; i < int.Parse(NumberOfCopiesTextBox.Text); i++)
            {
                var copyToAdd = new BookCopy(statusToAdd, _bookRepository.GetAllBooks().FirstOrDefault(book => book.ToString() == toAdd.ToString()));
                _bookCopyRepository.AddBookCopy(copyToAdd);
            }

            Close();
        }

        private bool CheckForErrors()
        {
            if ((string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(PageCountTextBox.Text)
                                                             || string.IsNullOrWhiteSpace(NumberOfCopiesTextBox.Text)
                                                             || string.IsNullOrWhiteSpace(GenreComboBox.Text)))
            {
                var fieldsError = new ErrorForm("You are missing some required fields!");
                fieldsError.ShowDialog();
                return false;
            }

            if (int.Parse(NumberOfCopiesTextBox.Text) > 50)
            {
                NumberOfCopiesTextBox.Text = @"50";
                var copiesError = new ErrorForm("You can add a maximum of 50 copies at once");
                copiesError.ShowDialog();
            }
            
            if (_bookRepository.GetAllBooks().FirstOrDefault(book =>
                    book.Name == NameTextBox.Text && book.Author.ToString() == AuthorComboBox.Text &&
                    book.Publisher.ToString() == PublisherComboBox.Text) == null) return true;
            var existingBook = new ErrorForm("That book already exists!");
            existingBook.ShowDialog();
            return false;
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) &&
                        !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ':';
        }

        private void PageCountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void NumberOfCopiesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
