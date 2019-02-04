using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Presentation.Forms.ManageForms;

namespace Library.Presentation.Forms
{
    public partial class ManageMainForm : Form
    {
        public ManageMainForm()
        {
            InitializeComponent();
        }

        private void AuthorsButton_Click(object sender, EventArgs e)
        {
            var manageAuthors = new ManageAuthorsForm();
            manageAuthors.ShowDialog();
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
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
