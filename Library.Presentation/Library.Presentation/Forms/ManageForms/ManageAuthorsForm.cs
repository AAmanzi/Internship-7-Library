using System;
using System.Linq;
using System.Windows.Forms;
using Library.Domain.Repositories;
using Library.Presentation.Forms.AddForms;
using Library.Presentation.Forms.EditForms;

namespace Library.Presentation.Forms.ManageForms
{
    public partial class ManageAuthorsForm : Form
    {
        private AuthorRepository _authorRepository;
        private BookRepository _bookRepository;
        public ManageAuthorsForm()
        {
            
            InitializeComponent();
            RefreshAuthorsListBox();
        }

        private void RefreshAuthorsListBox()
        {
            _authorRepository = new AuthorRepository();
            _bookRepository = new BookRepository();
            AuthorsListBox.Items.Clear();
            foreach (var author in _authorRepository.GetAllAuthors().OrderBy(author => author.LastName).ThenBy(author => author.Name))
            {
                AuthorsListBox.Items.Add(author.ToString());
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addAuthor = new AddAuthorForm();
            addAuthor.ShowDialog();

            RefreshAuthorsListBox();
        }

        private void AuthorsListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (var ix = 0; ix < AuthorsListBox.Items.Count; ++ix)
                if (ix != e.Index) AuthorsListBox.SetItemChecked(ix, false);
            
            RefreshAuthorInfoListBox();
        }

        private void RefreshAuthorInfoListBox()
        {
            AuthorInfoListBox.Items.Clear();
            var selected = AuthorsListBox.SelectedItem.ToString();
            var checkedAuthor = _authorRepository.GetAllAuthors()
                .FirstOrDefault(author => author.ToString() == selected);

            foreach (var book in _bookRepository.GetBooksByAuthor(checkedAuthor))
            {
                AuthorInfoListBox.Items.Add(book.Name);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!IsSafeToDelete())
                return;

            var selected = AuthorsListBox.SelectedItem.ToString();
            var checkedAuthor = _authorRepository.GetAllAuthors()
                .FirstOrDefault(author => author.ToString() == selected);

            _authorRepository.TryDelete(checkedAuthor);
            RefreshAuthorsListBox();
        }

        private bool IsSafeToDelete()
        {
            if (AuthorsListBox.SelectedItem == null)
                return false;

            var selected = AuthorsListBox.SelectedItem.ToString();
            var checkedAuthor = _authorRepository.GetAllAuthors()
                .First(author => author.ToString() == selected);

            if (_bookRepository.GetBooksByAuthor(checkedAuthor).Count != 0)
            {
                var bookError = new ErrorForm("You must first delete the author's books before deleting him/her");
                bookError.ShowDialog();
                return false;
            }

            var confirmCancel = new ConfirmForm();
            confirmCancel.ShowDialog();
            return confirmCancel.IsConfirmed;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (AuthorsListBox.CheckedItems.Count == 0)
                return;

            var selected = AuthorsListBox.SelectedItem.ToString();

            var editSelectedAuthor = new EditAuthorForm(selected);
            editSelectedAuthor.ShowDialog();
            RefreshAuthorsListBox();
        }
    }
}
