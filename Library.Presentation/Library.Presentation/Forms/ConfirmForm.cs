using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Presentation.Forms
{
    public partial class ConfirmForm : Form
    {
        public bool IsConfirmed;
        public ConfirmForm()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            IsConfirmed = true;
            Close();
        }

        private void NoButton_Click(object sender, EventArgs e)
        {
            IsConfirmed = false;
            Close();
        }
    }
}
