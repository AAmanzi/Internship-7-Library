using System.Collections.Generic;
using System.Linq;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace Library.Domain.Repositories
{
    public class BookRepository
    {
        private readonly LibraryContext _context;

        public BookRepository()
        {
            _context = new LibraryContext();
        }

        public ICollection<Book> GetAllBooks()
        {
            return _context.Books.Include(book => book.Author)
                .Include(book => book.Publisher).Include(book => book.BookCopies).ToList();
        }

        public ICollection<Book> GetBooksByAuthor(Author toGet)
        {
            return _context.Books.Where(book => book.Author == toGet).ToList();
        }

        public ICollection<Book> GetBooksByPublisher(Publisher toGet)
        {
            return _context.Books.Where(book => book.Publisher == toGet).ToList();
        }

        public bool IsBookAvailable(Book toCheck)
        {
            var bookToCheck = _context.Books.FirstOrDefault(book => book.ToString() == toCheck.ToString());
            if (bookToCheck == null)
                return false;
            var availableCopies = bookToCheck.BookCopies.Where(bookCopy => bookCopy.Status == BookStatus.Available);
            return availableCopies.Count() != 0;
        }

        public void AddBook(Book toAdd)
        {
            var tmpBook = new Book(toAdd.Name, toAdd.PageCount, toAdd.Genre,
                _context.Authors.Find(toAdd.Author.AuthorId), _context.Publishers.Find(toAdd.Publisher.PublisherId));
            _context.Books.Add(tmpBook);
            _context.SaveChanges();
        }

        public bool TryDelete(Book toDelete)
        {
            _context.Books.Remove(toDelete);
            var numberOfChanges = _context.SaveChanges();
            return numberOfChanges != 0;
        }

        public bool TryUpdate(Book toUpdate, Book updated)
        {
            var tmpToUpdate = GetAllBooks().FirstOrDefault(book => book.ToString() == toUpdate.ToString());

            if (tmpToUpdate == null)
                return false;

            tmpToUpdate.Name = updated.Name;
            tmpToUpdate.PageCount = updated.PageCount;
            tmpToUpdate.Genre = updated.Genre;
            tmpToUpdate.Author = _context.Authors.First(author => author == updated.Author);
            tmpToUpdate.Publisher = _context.Publishers.First(publisher => publisher == updated.Publisher);

            var numberOfChanges = _context.SaveChanges();
            return numberOfChanges != 0;
        }
    }
}
