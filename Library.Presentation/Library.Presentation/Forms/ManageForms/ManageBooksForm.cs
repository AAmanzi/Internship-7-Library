using System;
using System.Linq;
using System.Windows.Forms;
using Library.Data.Entities.Models;
using Library.Data.Enums;
using Library.Domain.Repositories;
using Library.Presentation.Forms.AddForms;
using Library.Presentation.Forms.EditForms;

namespace Library.Presentation.Forms.ManageForms
{
    public partial class ManageBooksForm : Form
    {
        private BookRepository _bookRepository;
        private BookCopyRepository _bookCopyRepository;
        public ManageBooksForm()
        {
            InitializeComponent();
            RefreshBooksListBox();
        }

        private void RefreshBooksListBox()
        {
            _bookRepository = new BookRepository();
            _bookCopyRepository = new BookCopyRepository();
            BooksListBox.Items.Clear();
            foreach (var book in _bookRepository.GetAllBooks().OrderBy(book => book.Name).ThenBy(book => book.Publisher))
            {
                BooksListBox.Items.Add(book);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addBook = new AddBookForm();
            addBook.ShowDialog();
            RefreshBooksListBox();
        }

        private void BooksListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (var ix = 0; ix < BooksListBox.Items.Count; ++ix)
                if (ix != e.Index) BooksListBox.SetItemChecked(ix, false);

            RefreshBookInfoListBox();
        }

        private void RefreshBookInfoListBox()
        {
            BookInfoListBox.Items.Clear();
            var selected = BooksListBox.SelectedItem.ToString();
            var checkedBook = _bookRepository.GetAllBooks()
                .FirstOrDefault(book => book.ToString() == selected);

            if (checkedBook == null)
                return;
            BookInfoListBox.Items.Add($"{checkedBook.PageCount} pages");
            BookInfoListBox.Items.Add($"Genre: {checkedBook.Genre}");

            var bookCopies = _bookCopyRepository.GetBookCopiesByBook(selected);

            BookInfoListBox.Items.Add($"Number of copies: {bookCopies.Count}");
            BookInfoListBox.Items.Add(
                $"Available copies: {bookCopies.Count(bookCopy => bookCopy.Status == BookStatus.Available)}");
        }

        private void AddCopiesButton_Click(object sender, EventArgs e)
        {
            if (BooksListBox.CheckedItems.Count == 0)
            {
                var selectError = new ErrorForm("You must select a book to add copies!");
                selectError.ShowDialog();
                return;
            }

            if (string.IsNullOrWhiteSpace(NumberOfCopiesToAddTextBox.Text))
                return;

            var selected = BooksListBox.SelectedItem.ToString();
            var checkedBook = _bookRepository.GetAllBooks().First(book => book.ToString() == selected);

            for (var i = 0; i < int.Parse(NumberOfCopiesToAddTextBox.Text); i++)
            {
                var copyToAdd = new BookCopy(BookStatus.Available,
                    _bookRepository.GetAllBooks().FirstOrDefault(book => book.ToString() == checkedBook.ToString()));
                _bookCopyRepository.AddBookCopy(copyToAdd);
            }

            NumberOfCopiesToAddTextBox.Text = "";
            RefreshBookInfoListBox();
        }

        private void DeleteCopiesButton_Click(object sender, EventArgs e)
        {
            if (BooksListBox.CheckedItems.Count == 0)
            {
                var selectError = new ErrorForm("You must select a book to delete copies!");
                selectError.ShowDialog();
                return;
            }

            if (string.IsNullOrWhiteSpace(NumberOfCopiesToDeleteTextBox.Text))
                return;

            var selected = BooksListBox.SelectedItem.ToString();
            var deletedAllAvailableCopies = false;


            for (var i = 0; i < int.Parse(NumberOfCopiesToDeleteTextBox.Text); i++)
            {
                var copyToDelete = _bookCopyRepository.GetAllBookCopies().FirstOrDefault(bookCopy =>
                    bookCopy.Book.ToString() == selected && bookCopy.Status == BookStatus.Available);

                if (copyToDelete == null)
                {
                    deletedAllAvailableCopies = true;
                    break;
                }
                _bookCopyRepository.TryDelete(copyToDelete);
            }

            if (_bookCopyRepository.GetAllBookCopies().FirstOrDefault(bookCopy => bookCopy.Book.ToString() == selected) == null)
            {
                _bookRepository = new BookRepository();
                _bookCopyRepository = new BookCopyRepository();
                var checkedBook = _bookRepository.GetAllBooks()
                    .FirstOrDefault(book => book.ToString() == selected);

                _bookRepository.TryDelete(checkedBook);
            }
            else if (deletedAllAvailableCopies)
            {
                var borrowedError = new ErrorForm("Borrowed copies cannot be deleted until returned!");
                borrowedError.ShowDialog();
            }

            NumberOfCopiesToDeleteTextBox.Text = "";
            RefreshBookInfoListBox();
            RefreshBooksListBox();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!IsSafeToDelete())
                return;

            var selected = BooksListBox.SelectedItem.ToString();
            var bookCopies = _bookCopyRepository.GetBookCopiesByBook(selected);

            foreach (var bookCopy in bookCopies)
            {
                _bookCopyRepository.TryDelete(bookCopy);
            }
            _bookRepository = new BookRepository();
            _bookCopyRepository = new BookCopyRepository();

            var checkedBook = _bookRepository.GetAllBooks()
                .FirstOrDefault(book => book.ToString() == selected);
            _bookRepository.TryDelete(checkedBook);
            RefreshBooksListBox();
            BookInfoListBox.Items.Clear();
        }

        private bool IsSafeToDelete()
        {
            if (BooksListBox.SelectedItem == null)
                return false;

            var selected = BooksListBox.SelectedItem.ToString();
            var bookCopies = _bookCopyRepository.GetBookCopiesByBook(selected);
            if (bookCopies.Count != bookCopies.Count(bookCopy => bookCopy.Status == BookStatus.Available))
            {
                var copyError = new ErrorForm("You cannot delete a book that has borrowed copies");
                copyError.ShowDialog();
                return false;
            }

            var confirmCancel = new ConfirmForm();
            confirmCancel.ShowDialog();
            return confirmCancel.IsConfirmed;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (BooksListBox.CheckedItems.Count == 0)
                return;

            var selected = BooksListBox.SelectedItem.ToString();

            var editSelectedBook = new EditBookForm(selected);
            editSelectedBook.ShowDialog();
            RefreshBooksListBox();
        }

        private void NumberOfCopiesToAddTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void NumberOfCopiesToDeleteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}