using System;
using System.Linq;
using System.Windows.Forms;
using Library.Domain.Repositories;
using Library.Presentation.Forms.AddForms;

namespace Library.Presentation.Forms.ManageForms
{
    public partial class ManageAuthorsForm : Form
    {
        private AuthorRepository _allAuthors;
        private BookRepository _allBooks;
        public ManageAuthorsForm()
        {
            
            InitializeComponent();
            RefreshAuthorsListBox();
        }

        private void RefreshAuthorsListBox()
        {
            _allAuthors = new AuthorRepository();
            _allBooks = new BookRepository();
            AuthorsListBox.Items.Clear();
            foreach (var author in _allAuthors.GetAllAuthors().OrderBy(author => author.LastName).ThenBy(author => author.Name))
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
            var checkedAuthor = _allAuthors.GetAllAuthors()
                .FirstOrDefault(author => author.ToString() == selected);

            foreach (var book in _allBooks.GetBooksByAuthor(checkedAuthor))
            {
                AuthorInfoListBox.Items.Add(book.Name);
            }
        }
    }
}
