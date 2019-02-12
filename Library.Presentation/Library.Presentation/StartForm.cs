using System;
using System.Windows.Forms;
using Library.Presentation.Forms;
using Library.Presentation.Forms.AddForms;

namespace Library.Presentation
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            var view = new ViewMainForm();
            view.ShowDialog();
        }

        private void ManageButton_Click(object sender, EventArgs e)
        {
            var manage = new ManageMainForm();
            manage.ShowDialog();
        }

        private void RentButton_Click(object sender, EventArgs e)
        {
            var rent = new AddBorrowEventForm();
            rent.ShowDialog();
        }

        private void RentReturnButton_Click(object sender, EventArgs e)
        {
            var returnBorrow = new ReturnBorrowEventForm();
            returnBorrow.ShowDialog();
        }
    }
}
