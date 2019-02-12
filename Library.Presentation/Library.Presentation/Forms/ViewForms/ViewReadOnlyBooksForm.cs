using System.Linq;
using System.Windows.Forms;
using Library.Data.Enums;
using Library.Domain.Repositories;

namespace Library.Presentation.Forms.ViewForms
{
    public partial class ViewReadOnlyBooksForm : Form
    {
        private readonly BookCopyRepository _bookCopyRepository;
        public ViewReadOnlyBooksForm()
        {
            InitializeComponent();
            _bookCopyRepository = new BookCopyRepository();
            LoadReadOnlyBooksTextBox();
        }

        private void LoadReadOnlyBooksTextBox()
        {
            var readOnlyBookCopies =
                _bookCopyRepository.GetAllBookCopies().Where(bookCopy => bookCopy.Status == BookStatus.ReadOnly)
                    .GroupBy(bookCopy => bookCopy.Book.ToString()).ToList();
            foreach (var bookCopy in readOnlyBookCopies)
            {
                ReadOnlyBooksListBox.Items.Add(bookCopy.Key);
            }
        }
    }
}
