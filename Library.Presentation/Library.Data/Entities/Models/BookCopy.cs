using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Enums;

namespace Library.Data.Entities.Models
{
    public class BookCopy
    {
        public int BookCopyId { get; set; }
        public BookStatus Status { get; set; }

        public Book Book { get; set; }
        public ICollection<BorrowEvent> BorrowEvents { get; set; }

        public BookCopy()
        {
            
        }

        public BookCopy(BookStatus status, Book book)
        {
            Status = status;
            Book = book;
        }

        public override string ToString()
        {
            return $"{Book.Name} {Status}";
        }
    }
}
