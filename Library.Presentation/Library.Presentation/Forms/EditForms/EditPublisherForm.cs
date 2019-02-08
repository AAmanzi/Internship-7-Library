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
using Library.Domain.Repositories;

namespace Library.Presentation.Forms.EditForms
{
    public partial class EditPublisherForm : Form
    {
        private PublisherRepository _publisherRepository;
        private readonly string _selectedPublisher;
        public EditPublisherForm(string selectedPublisher)
        {
            InitializeComponent();
            _selectedPublisher = selectedPublisher;
            _publisherRepository = new PublisherRepository();
            LoadPublisherInfo();
        }

        private void LoadPublisherInfo()
        {
            var publisherToUpdate = _publisherRepository.GetAllPublishers()
                .First(publisher => publisher.ToString() == _selectedPublisher);

            NameTextBox.Text = publisherToUpdate.Name;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //check errors
            var publisherToUpdate = _publisherRepository.GetAllPublishers()
                .First(publisher => publisher.ToString() == _selectedPublisher);

            var authorUpdated = new Publisher(NameTextBox.Text);

            _publisherRepository.TryUpdate(publisherToUpdate, authorUpdated);
            Close();
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
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
    }
}
