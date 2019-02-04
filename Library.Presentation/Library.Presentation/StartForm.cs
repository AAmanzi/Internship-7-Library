using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Domain.Repositories;
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
    }
}
