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

namespace Library.Presentation.Forms.ViewForms
{
    public partial class ViewOverdueBorrowEventsForm : Form
    {
        private readonly BorrowEventRepository _borrowEventRepository;
        public ViewOverdueBorrowEventsForm()
        {
            InitializeComponent();
            _borrowEventRepository = new BorrowEventRepository();
            LoadOverdueBorrowEventsListBox();
        }

        private void LoadOverdueBorrowEventsListBox()
        {
            var currentBorrowEvents = _borrowEventRepository.GetAllBorrowEvents()
                .Where(borrowEvent => borrowEvent.DateOfReturn == null
                                      && DateTime.Now - borrowEvent.DateOfBorrow > new TimeSpan(30, 0, 0, 0))
                .OrderBy(borrowEvent => borrowEvent.Student.LastName).ThenBy(borrowEvent => borrowEvent.Student.Name)
                .ThenBy(borrowEvent => borrowEvent.BookCopy.Book.ToString())
                .GroupBy(borrowEvent => borrowEvent.Student.ToString()).ToList();
            foreach (var borrowEvent in currentBorrowEvents)
            {
                OverdueBorrowEventsListBox.Items.Add(borrowEvent.Key);
                foreach (var item in borrowEvent)
                {
                    OverdueBorrowEventsListBox.Items.Add(
                        $"\t {item.BookCopy.Book}");
                    OverdueBorrowEventsListBox.Items.Add($"\t\tRented on: {item.DateOfBorrow :dd/MM/yyyy}");
                }

                OverdueBorrowEventsListBox.Items.Add("");
            }
        }
    }
}
