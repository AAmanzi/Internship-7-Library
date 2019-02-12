using System.Linq;
using System.Windows.Forms;
using Library.Domain.Repositories;

namespace Library.Presentation.Forms.ViewForms
{
    public partial class ViewCurrentBorrowEventsForm : Form
    {
        private readonly BorrowEventRepository _borrowEventRepository;
        public ViewCurrentBorrowEventsForm()
        {
            InitializeComponent();
            _borrowEventRepository = new BorrowEventRepository();
            LoadCurrentBorrowEventsListBox();
        }

        private void LoadCurrentBorrowEventsListBox()
        {
            var currentBorrowEvents = _borrowEventRepository.GetAllBorrowEvents()
                .Where(borrowEvent => borrowEvent.DateOfReturn == null)
                .OrderBy(borrowEvent => borrowEvent.Student.LastName).ThenBy(borrowEvent => borrowEvent.Student.Name)
                .ThenBy(borrowEvent => borrowEvent.BookCopy.Book.ToString())
                .GroupBy(borrowEvent => borrowEvent.Student.ToString()).ToList();
            foreach (var borrowEvent in currentBorrowEvents)
            {
                CurrentBorrowEventsListBox.Items.Add(borrowEvent.Key);
                foreach (var item in borrowEvent)
                {
                    CurrentBorrowEventsListBox.Items.Add(
                        $"\t {item.BookCopy.Book}");
                    CurrentBorrowEventsListBox.Items.Add($"\t\tRented on: {item.DateOfBorrow :dd/MM/yyyy}");
                }

                CurrentBorrowEventsListBox.Items.Add("");
            }
        }
    }
}
