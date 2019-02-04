using System;
using System.Linq;
using System.Windows.Forms;
using Library.Domain.Repositories;
using Library.Presentation.Forms.AddForms;

namespace Library.Presentation.Forms.ManageForms
{
    public partial class ManageBooksForm : Form
    {
        private BookRepository _allBooks;
        public ManageBooksForm()
        {
            InitializeComponent();
            RefreshBooksListBox();
        }

        private void RefreshBooksListBox()
        {
            _allBooks = new BookRepository();
            BooksListBox.Items.Clear();
            foreach (var book in _allBooks.GetAllBooks().OrderBy(book => book.Name).ThenBy(book => book.Publisher))
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
            var checkedBook = _allBooks.GetAllBooks()
                .FirstOrDefault(book => book.ToString() == selected);

            if (checkedBook == null)
                return;
            BookInfoListBox.Items.Add($"{checkedBook.PageCount} pages");
            BookInfoListBox.Items.Add($"Genre: {checkedBook.Genre}");
        }
    }
}
