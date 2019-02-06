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
            return _context.BorrowEvents.Include(be => be.BookCopy).ThenInclude(bc => bc.Book)
                .ThenInclude(bk => bk.Author).Include(be => be.BookCopy).ThenInclude(bc => bc.Book)
                .ThenInclude(bk => bk.Publisher).Where(borrowEvent => borrowEvent.Student.StudentId ==
                                                                      _context.Students.FirstOrDefault(student =>
                                                                              student.ToString() == toGetStudentString)
                                                                          .StudentId &&
                                                                      borrowEvent.DateOfReturn == null)
                .ToList();
        }

        public BorrowEvent GetBorrowEvent(int toGetId)
        {
            return _context.BorrowEvents.Find(toGetId);
        }

        public void AddBorrowEvent(BorrowEvent toAdd)
        {
            _context.BookCopies.Find(toAdd.BookCopy.BookCopyId).Status = BookStatus.Borrowed;
            var tmpBorrowEvent = new BorrowEvent(toAdd.DateOfBorrow, null,
                _context.Students.Find(toAdd.Student.StudentId), _context.BookCopies.Find(toAdd.BookCopy.BookCopyId));
            _context.BorrowEvents.Add(tmpBorrowEvent);
            _context.SaveChanges();
        }

        public bool TryDelete(int toDeleteId)
        {
            var toDelete = GetBorrowEvent(toDeleteId);
            if (toDelete == null)
                return false;
            _context.BorrowEvents.Remove(toDelete);
            _context.SaveChanges();
            return true;
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
