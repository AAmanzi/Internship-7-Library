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

        public bool IsBookAvailable(Book toCheck)
        {
            var bookToCheck = _context.Books.FirstOrDefault(book => book.ToString() == toCheck.ToString());
            if (bookToCheck == null)
                return false;
            var availableCopies = bookToCheck.BookCopies.Where(bookCopy => bookCopy.Status == BookStatus.Available);
            return availableCopies.Count() != 0;
        }
        public ICollection<Book> GetAvailableBooks()
        {
            return _context.Books.Where(book => IsBookAvailable(book)).ToList();
        }

        public ICollection<Book> GetBooksByPublisher(Publisher toGet)
        {
            return _context.Books.Where(book => book.Publisher == toGet).ToList();
        }

        public Book GetBook(int toGetId)
        {
            return _context.Books.Find(toGetId);
        }

        public void AddBook(Book toAdd)
        {
            var tmpBook = new Book(toAdd.Name, toAdd.PageCount, toAdd.Genre, toAdd.AvailableCopies,
                _context.Authors.Find(toAdd.Author.AuthorId), _context.Publishers.Find(toAdd.Publisher.PublisherId));
            _context.Books.Add(tmpBook);
            _context.SaveChanges();
        }

        public bool TryDelete(int toDeleteId)
        {
            var toDelete = GetBook(toDeleteId);
            if (toDelete == null)
                return false;
            _context.Books.Remove(toDelete);
            _context.SaveChanges();
            return true;
        }

        public bool TryUpdate(int bookToUpdateId, Book updated)
        {
            var toUpdate = GetBook(bookToUpdateId);

            if (toUpdate == null)
                return false;

            toUpdate.Name = updated.Name;
            toUpdate.PageCount = updated.PageCount;
            toUpdate.Genre = updated.Genre;
            toUpdate.AvailableCopies = updated.AvailableCopies;
            toUpdate.Author = updated.Author;
            toUpdate.Publisher = updated.Publisher;

            _context.SaveChanges();
            return true;
        }
    }
}
