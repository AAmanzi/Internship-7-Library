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
using Library.Infrastructure.Extensions;

namespace Library.Presentation.Forms.EditForms
{
    public partial class EditPublisherForm : Form
    {
        private readonly PublisherRepository _publisherRepository;
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
            NameTextBox.Text = NameTextBox.Text.TrimAndRemoveWhiteSpaces().FirstLetterToUpper();
            if (!CheckForErrors())
                return;
            var publisherToUpdate = _publisherRepository.GetAllPublishers()
                .First(publisher => publisher.ToString() == _selectedPublisher);

            var authorUpdated = new Publisher(NameTextBox.Text);

            _publisherRepository.TryUpdate(publisherToUpdate, authorUpdated);
            Close();
        }

        private bool CheckForErrors()
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                var fieldsError = new ErrorForm("You are missing some required fields!");
                fieldsError.ShowDialog();
                return false;
            }

            var publisherToUpdate = _publisherRepository.GetAllPublishers()
                .First(publisher => publisher.ToString() == _selectedPublisher);

            if (publisherToUpdate.Name == NameTextBox.Text)
            {
                Close();
                return false;
            }

            if (_publisherRepository.GetAllPublishers()
                    .FirstOrDefault(publisher => publisher.Name == NameTextBox.Text) == null) return true;
            var existingPublisher = new ErrorForm("That publisher already exists!");
            existingPublisher.ShowDialog();
            return false;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
    }
}
