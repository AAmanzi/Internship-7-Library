using System;
using System.Windows.Forms;
using Library.Domain.Repositories;
using Library.Presentation.Forms.ManageForms;

namespace Library.Presentation.Forms
{
    public partial class ManageMainForm : Form
    {
        private readonly PublisherRepository _publisherRepository;
        private readonly AuthorRepository _authorRepository;
        public ManageMainForm()
        {
            InitializeComponent();
            _publisherRepository = new PublisherRepository();
            _authorRepository = new AuthorRepository();
        }

        private void AuthorsButton_Click(object sender, EventArgs e)
        {
            var manageAuthors = new ManageAuthorsForm();
            manageAuthors.ShowDialog();
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            if (_publisherRepository.GetAllPublishers().Count == 0 || _authorRepository.GetAllAuthors().Count == 0)
            {
                var booksError =
                    new ErrorForm("In order to manage books there must be at least one author and one publisher");
                booksError.ShowDialog();
                return;
            }
            var manageBooks = new ManageBooksForm();
            manageBooks.ShowDialog();
        }

        private void PublishersButton_Click(object sender, EventArgs e)
        {
            var managePublishers = new ManagePublishersForm();
            managePublishers.ShowDialog();
        }

        private void StudentsButton_Click(object sender, EventArgs e)
        {
            var manageStudents = new ManageStudentsForm();
            manageStudents.ShowDialog();
        }
    }
}
