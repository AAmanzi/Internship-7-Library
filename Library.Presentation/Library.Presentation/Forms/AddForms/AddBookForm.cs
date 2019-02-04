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
        private readonly BookRepository _allBooks;
        private readonly AuthorRepository _allAuthors;
        private readonly PublisherRepository _allPublishers;
        private readonly BookCopyRepository _allBookCopies;
        public AddBookForm()
        {
            _allBooks = new BookRepository();
            _allAuthors = new AuthorRepository();
            _allPublishers = new PublisherRepository();
            _allBookCopies = new BookCopyRepository();
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
            foreach (var author in _allAuthors.GetAllAuthors())
            {
                AuthorComboBox.Items.Add($"{author.Name} {author.LastName}");
            }
        }

        private void LoadPublisherComboBox()
        {
            foreach (var publisher in _allPublishers.GetAllPublishers())
            {
                PublisherComboBox.Items.Add($"{publisher.Name}");
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

            var toAdd = new Book
            {
                Name = NameTextBox.Text,
                PageCount = PageCountTextBox.Text,
                Genre = (Genre)Enum.Parse(typeof(Genre), GenreComboBox.Text),
                Author = _allAuthors.GetAllAuthors().FirstOrDefault(author => (author.Name + @" " + author.LastName) == AuthorComboBox.Text),
                Publisher = _allPublishers.GetAllPublishers().FirstOrDefault(publisher => publisher.Name == PublisherComboBox.Text)
            };

            _allBooks.AddBook(toAdd);
            

            for (var i = 0; i < int.Parse(NumberOfCopiesTextBox.Text); i++)
            {
                var copyToAdd = new BookCopy(BookStatus.Available, _allBooks.GetAllBooks().FirstOrDefault(book => book.ToString() == toAdd.ToString()));
                _allBookCopies.AddBookCopy(copyToAdd);
            }

            Close();
        }

        private bool CheckForErrors()
        {
            return (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(PageCountTextBox.Text)
                    || string.IsNullOrWhiteSpace(NumberOfCopiesTextBox.Text) || string.IsNullOrWhiteSpace(GenreComboBox.Text));
        }
    }
}
