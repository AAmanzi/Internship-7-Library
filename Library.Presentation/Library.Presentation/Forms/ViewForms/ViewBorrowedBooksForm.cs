using System.Linq;
using System.Windows.Forms;
using Library.Data.Enums;
using Library.Domain.Repositories;

namespace Library.Presentation.Forms.ViewForms
{
    public partial class ViewBorrowedBooksForm : Form
    {
        private BookCopyRepository _bookCopyRepository;
        private BorrowEventRepository _borrowEventRepository;
        public ViewBorrowedBooksForm()
        {
            InitializeComponent();
            RefreshBooksListBox();
        }

        private void RefreshBooksListBox()
        {
            _bookCopyRepository = new BookCopyRepository();
            _borrowEventRepository = new BorrowEventRepository();
            BooksListBox.Items.Clear();

            var borrowedBookCopiesByBook = _bookCopyRepository.GetAllBookCopies()
                .Where(bookCopy => bookCopy.Status == BookStatus.Borrowed)
                .GroupBy(bookCopy => bookCopy.Book.ToString());

            foreach (var bookCopy in borrowedBookCopiesByBook)
            {
                BooksListBox.Items.Add(bookCopy.Key);
            }
        }

        private void BooksListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            for (var ix = 0; ix < BooksListBox.Items.Count; ++ix)
                if (ix != e.Index) BooksListBox.SetItemChecked(ix, false);

            RefreshBookInfoListBox();
        }

        private void RefreshBookInfoListBox()
        {
            BookInfoListBox.Items.Clear();
            var selected = BooksListBox.SelectedItem.ToString();

            foreach (var borrowEvent in _borrowEventRepository.GetBorrowEventsByBook(selected))
            {
                BookInfoListBox.Items.Add(borrowEvent.Student);
            }
        }
    }
}
