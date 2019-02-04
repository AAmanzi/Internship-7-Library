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
            return _context.BorrowEvents.Include(be => be.Student).Include(be => be.BookCopy).ToList();
        }

        public ICollection<BorrowEvent> GetBorrowEventsByStudent(Student toGet)
        {
            return _context.BorrowEvents.Where(borrowEvent => borrowEvent.Student == toGet).ToList();
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
    }
}
