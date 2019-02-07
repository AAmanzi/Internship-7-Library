using System;
using System.Linq;
using System.Windows.Forms;
using Library.Domain.Repositories;
using Library.Presentation.Forms.AddForms;

namespace Library.Presentation.Forms.ManageForms
{
    public partial class ManagePublishersForm : Form
    {
        private PublisherRepository _publisherRepository;
        private BookRepository _bookRepository;
        public ManagePublishersForm()
        {
            InitializeComponent();
            RefreshPublishersListBox();
        }

        private void RefreshPublishersListBox()
        {
            _publisherRepository = new PublisherRepository();
            _bookRepository = new BookRepository();
            PublishersListBox.Items.Clear();
            foreach (var book in _publisherRepository.GetAllPublishers())
            {
                PublishersListBox.Items.Add(book);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addPublisher = new AddPublisherForm();
            addPublisher.ShowDialog();
            RefreshPublishersListBox();
        }

        private void PublishersListBox_ItemCheck(object sender, ItemCheckEventArgs e) 
        {
            for (var ix = 0; ix < PublishersListBox.Items.Count; ++ix)
                if (ix != e.Index) PublishersListBox.SetItemChecked(ix, false);
            RefreshPublisherInfoListBox();
        }

        private void RefreshPublisherInfoListBox()
        {
            PublisherInfoListBox.Items.Clear();
            var selected = PublishersListBox.SelectedItem.ToString();
            var checkedPublisher = _publisherRepository.GetAllPublishers()
                .FirstOrDefault(author => author.ToString() == selected);

            foreach (var book in _bookRepository.GetBooksByPublisher(checkedPublisher))
            {
                PublisherInfoListBox.Items.Add(book.Name);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (!IsSafeToDelete())
                return;

            var selected = PublishersListBox.SelectedItem.ToString();
            var checkedPublisher = _publisherRepository.GetAllPublishers()
                .FirstOrDefault(publisher => publisher.ToString() == selected);

            _publisherRepository.TryDelete(checkedPublisher);
            RefreshPublishersListBox();
        }

        private bool IsSafeToDelete()
        {
            if (PublishersListBox.SelectedItem == null)
                return false;

            var selected = PublishersListBox.SelectedItem.ToString();
            var checkedPublisher = _publisherRepository.GetAllPublishers()
                .FirstOrDefault(publisher => publisher.ToString() == selected);

            if (_bookRepository.GetBooksByPublisher(checkedPublisher).Count != 0)
            {
                var bookError = new ErrorForm("You must first delete the publisher's books before deleting him/her");
                bookError.ShowDialog();
                return false;
            }

            var confirmCancel = new ConfirmForm();
            confirmCancel.ShowDialog();
            return confirmCancel.IsConfirmed;
        }
    }
}
