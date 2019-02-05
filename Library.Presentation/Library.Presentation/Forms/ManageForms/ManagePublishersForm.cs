using System;
using System.Windows.Forms;
using Library.Domain.Repositories;
using Library.Presentation.Forms.AddForms;

namespace Library.Presentation.Forms.ManageForms
{
    public partial class ManagePublishersForm : Form
    {
        private PublisherRepository _publisherRepository;
        public ManagePublishersForm()
        {
            InitializeComponent();
            RefreshPublishersListBox();
        }

        private void RefreshPublishersListBox()
        {
            _publisherRepository = new PublisherRepository();
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

        private void PublishersListBox_ItemCheck(object sender, ItemCheckEventArgs e) {
            for (var ix = 0; ix < PublishersListBox.Items.Count; ++ix)
                if (ix != e.Index) PublishersListBox.SetItemChecked(ix, false);
        }
    }
}
