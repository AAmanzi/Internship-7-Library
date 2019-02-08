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

namespace Library.Presentation.Forms.EditForms
{
    public partial class EditBookForm : Form
    {
        private BookRepository _bookRepository;
        private AuthorRepository _authorRepository;
        private PublisherRepository _publisherRepository;
        private readonly string _selectedBook;
        public EditBookForm(string selectedBook)
        {
            InitializeComponent();
            _selectedBook = selectedBook;
            _bookRepository = new BookRepository();
            _authorRepository = new AuthorRepository();
            _publisherRepository = new PublisherRepository();
            LoadBookInfo();
            LoadGenreComboBox();
            LoadAuthorComboBox();
            LoadPublisherComboBox();
            LoadBookInfo();
        }

        private void LoadBookInfo()
        {
            var bookToUpdate = _bookRepository.GetAllBooks()
                .First(book => book.ToString() == _selectedBook);

            NameTextBox.Text = bookToUpdate.Name;
            PageCountTextBox.Text = bookToUpdate.PageCount;
            GenreComboBox.Text = bookToUpdate.Genre.ToString();
            AuthorComboBox.Text = bookToUpdate.Author.ToString();
            PublisherComboBox.Text = bookToUpdate.Publisher.ToString();
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!CheckForErrors())
                return;

            var bookToUpdate = _bookRepository.GetAllBooks()
                .First(book => book.ToString() == _selectedBook);

            var newAuthor = _authorRepository.GetAllAuthors().First(author => author.ToString() == AuthorComboBox.Text);
            var newPublisher = _publisherRepository.GetAllPublishers()
                .First(publisher => publisher.ToString() == PublisherComboBox.Text);

            var bookUpdated = new Book(NameTextBox.Text, PageCountTextBox.Text,
                (Genre) Enum.Parse(typeof(Genre), GenreComboBox.Text), newAuthor, newPublisher);

            _bookRepository.TryUpdate(bookToUpdate, bookUpdated);
            Close();
        }

        private bool CheckForErrors()
        {
            if ((string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(PageCountTextBox.Text)
                                                             || string.IsNullOrWhiteSpace(GenreComboBox.Text)))
            {
                var fieldsError = new ErrorForm("You are missing some required fields!");
                fieldsError.ShowDialog();
                return false;
            }
            
            var bookToUpdate = _bookRepository.GetAllBooks()
                .First(book => book.ToString() == _selectedBook);

            if (bookToUpdate.Name == NameTextBox.Text && bookToUpdate.Author.ToString() == AuthorComboBox.Text &&
                bookToUpdate.Publisher.ToString() == PublisherComboBox.Text) return true;

            if (_bookRepository.GetAllBooks().FirstOrDefault(book =>
                    book.Name == NameTextBox.Text && book.Author.ToString() == AuthorComboBox.Text &&
                    book.Publisher.ToString() == PublisherComboBox.Text) == null) return true;
            var existingBook = new ErrorForm("That book already exists!");
            existingBook.ShowDialog();
            return false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var confirmCancel = new ConfirmForm();
            confirmCancel.ShowDialog();
            if (confirmCancel.IsConfirmed)
                Close();
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
    }
}
