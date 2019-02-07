using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace Library.Domain.Repositories
{
    public class BookCopyRepository
    {
        private readonly LibraryContext _context;

        public BookCopyRepository()
        {
            _context = new LibraryContext();
        }

        public ICollection<BookCopy> GetAllBookCopies()
        {
            return _context.BookCopies
                .Include(bc => bc.Book)
                    .ThenInclude(book => book.Author)
                .Include(bc => bc.Book)
                    .ThenInclude(book => book.Publisher).ToList();
        }

        public ICollection<BookCopy> GetBookCopiesByBook(string bookToGet)
        {
            return GetAllBookCopies().Where(bookCopy => bookCopy.Book.ToString() == bookToGet).ToList();
        }

        public void AddBookCopy(BookCopy toAdd)
        {
            var tmpBookCopy = new BookCopy(toAdd.Status, _context.Books.Find(toAdd.Book.BookId));
            _context.BookCopies.Add(tmpBookCopy);
            _context.SaveChanges();
        }

        public bool TryDelete(BookCopy toDelete)
        {
            _context.BookCopies.Remove(toDelete);
            var numberOfChanges = _context.SaveChanges();
            return numberOfChanges != 0;
        }
        
        /*
        public bool TryUpdate(int bookCopyToUpdateId, BookCopy updated)
        {
            var toUpdate = GetBookCopy(bookCopyToUpdateId);

            if (toUpdate == null)
                return false;

            toUpdate.Book = updated.Book;
            toUpdate.Status = updated.Status;

            _context.SaveChanges();
            return true;
        }
        */
    }
}
