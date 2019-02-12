using System;
using System.Collections.Generic;
using System.Linq;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Data.Enums;
using Microsoft.EntityFrameworkCore;

namespace Library.Domain.Repositories
{
    public class BorrowEventRepository
    {
        private readonly LibraryContext _context;

        public BorrowEventRepository()
        {
            _context = new LibraryContext();
        }

        public ICollection<BorrowEvent> GetAllBorrowEvents()
        {
            return _context.BorrowEvents.Include(be => be.Student).Include(be => be.BookCopy).ThenInclude(bc => bc.Book)
                .ThenInclude(bk => bk.Author).Include(be => be.BookCopy).ThenInclude(bc => bc.Book)
                .ThenInclude(bk => bk.Publisher).ToList();
        }

        public ICollection<BorrowEvent> GetBorrowEventsByStudent(string toGetStudentString)
        {
            return GetAllBorrowEvents().Where(borrowEvent => borrowEvent.Student ==
                                                             _context.Students.FirstOrDefault(student =>
                                                                 student.ToString() == toGetStudentString) &&
                                                             borrowEvent.DateOfReturn == null).ToList();
        }

        public ICollection<BorrowEvent> GetBorrowEventsByBook(string toGetBookString)
        {
            return GetAllBorrowEvents().Where(borrowEvent => borrowEvent.BookCopy.Book ==
                                                             _context.Books.FirstOrDefault(book =>
                                                                 book.ToString() == toGetBookString) &&
                                                             borrowEvent.DateOfReturn == null).ToList();
        }

        public void AddBorrowEvent(BorrowEvent toAdd)
        {
            _context.BookCopies.Find(toAdd.BookCopy.BookCopyId).Status = BookStatus.Borrowed;
            var tmpBorrowEvent = new BorrowEvent(toAdd.DateOfBorrow, null,
                _context.Students.Find(toAdd.Student.StudentId), _context.BookCopies.Find(toAdd.BookCopy.BookCopyId));
            _context.BorrowEvents.Add(tmpBorrowEvent);
            _context.SaveChanges();
        }

        public bool ReturnBookEvent(BorrowEvent toReturn, DateTime dateOfReturn)
        {
            var eventToReturn = GetAllBorrowEvents().First(borrowEvent =>
                borrowEvent.Student.ToString() == toReturn.Student.ToString() &&
                borrowEvent.BookCopy.Book.ToString() == toReturn.BookCopy.Book.ToString() && borrowEvent.DateOfReturn == null);

            if (eventToReturn == null)
                return false;

            _context.BookCopies.Find(toReturn.BookCopy.BookCopyId).Status = BookStatus.Available;
            eventToReturn.DateOfReturn = dateOfReturn;
            var numberOfChanges =_context.SaveChanges();
            return (numberOfChanges != 0);
        }
    }
}
