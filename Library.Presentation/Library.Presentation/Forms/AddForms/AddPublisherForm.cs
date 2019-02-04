﻿using System;
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

namespace Library.Presentation.Forms.AddForms
{
    public partial class AddPublisherForm : Form
    {
        private readonly PublisherRepository _allPublishers;
        public AddPublisherForm()
        {
            _allPublishers = new PublisherRepository();
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            var confirmCancel = new ConfirmForm();
            confirmCancel.ShowDialog();
            if (confirmCancel.IsConfirmed)
                Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CheckForErrors())
            {
                var fieldsError = new ErrorForm("You are missing some required fields!");
                fieldsError.ShowDialog();
                return;
            }

            var toAdd = new Publisher
            {
                Name = NameTextBox.Text
            };

            _allPublishers.AddPublisher(toAdd);
            Close();
        }

        private bool CheckForErrors()
        {
            return string.IsNullOrWhiteSpace(NameTextBox.Text);
        }
    }
}