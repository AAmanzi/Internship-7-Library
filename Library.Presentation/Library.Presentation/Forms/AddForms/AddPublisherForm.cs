using System;
using System.Linq;
using System.Windows.Forms;
using Library.Data.Entities.Models;
using Library.Domain.Repositories;
using Library.Infrastructure.Extensions;

namespace Library.Presentation.Forms.AddForms
{
    public partial class AddPublisherForm : Form
    {
        private readonly PublisherRepository _publisherRepository;
        public AddPublisherForm()
        {
            _publisherRepository = new PublisherRepository();
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            NameTextBox.Text = NameTextBox.Text.TrimAndRemoveWhiteSpaces().FirstLetterToUpper();

            if (!CheckForErrors())
                return;

            var toAdd = new Publisher(NameTextBox.Text);

            _publisherRepository.AddPublisher(toAdd);
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

            if (_publisherRepository.GetAllPublishers()
                    .FirstOrDefault(publisher => publisher.Name == NameTextBox.Text) == null) return true;
            var existingPublisher = new ErrorForm("That publisher already exists!");
            existingPublisher.ShowDialog();
            return false;
        }

        private void NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
    }
}
