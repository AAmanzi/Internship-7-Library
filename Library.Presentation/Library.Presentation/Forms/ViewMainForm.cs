using System;
using System.Windows.Forms;
using Library.Presentation.Forms.ViewForms;

namespace Library.Presentation.Forms
{
    public partial class ViewMainForm : Form
    {
        public ViewMainForm()
        {
            InitializeComponent();
        }

        private void BorrowedBooksButton_Click(object sender, EventArgs e)
        {
            var borrowedBooks = new ViewBorrowedBooksForm();
            borrowedBooks.ShowDialog();
        }

        private void ReadOnlyBooksButton_Click(object sender, EventArgs e)
        {
            var readOnlyBooks = new ViewReadOnlyBooksForm();
            readOnlyBooks.ShowDialog();
        }

        private void CurrentBorrowEventsButton_Click(object sender, EventArgs e)
        {
            var currentBorrowEvents = new ViewCurrentBorrowEventsForm();
            currentBorrowEvents.ShowDialog();
        }

        private void OverdueBorrowEventsButton_Click(object sender, EventArgs e)
        {
            var overdueBorrowEvents = new ViewOverdueBorrowEventsForm();
            overdueBorrowEvents.ShowDialog();
        }
    }
}
