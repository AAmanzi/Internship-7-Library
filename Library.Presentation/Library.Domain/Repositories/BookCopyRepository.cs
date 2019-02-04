﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities;
using Library.Data.Entities.Models;
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

        public BookCopy GetBookCopy(int toGetId)
        {
            return _context.BookCopies.Find(toGetId);
        }

        public void AddBookCopy(BookCopy toAdd)
        {
            var tmpBookCopy = new BookCopy(toAdd.Status, _context.Books.Find(toAdd.Book.BookId));
            _context.BookCopies.Add(tmpBookCopy);
            _context.SaveChanges();
        }

        public bool TryDelete(int toDeleteId)
        {
            var toDelete = GetBookCopy(toDeleteId);
            if (toDelete == null)
                return false;
            _context.BookCopies.Remove(toDelete);
            _context.SaveChanges();
            return true;
        }

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
    }
}