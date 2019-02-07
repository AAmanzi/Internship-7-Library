using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Data.Enums;

namespace Library.Domain.Repositories
{
    public class StudentRepository
    {
        private readonly LibraryContext _context;
        public StudentRepository()
        {
            _context = new LibraryContext();
        }

        public ICollection<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudent(int toGetId)
        {
            return _context.Students.Find(toGetId);
        }

        public void AddStudent(Student toAdd)
        {
            _context.Students.Add(toAdd);
            _context.SaveChanges();
        }

        public bool TryDelete(Student toDelete)
        {
            _context.Students.Remove(toDelete);
            var numberOfChanges = _context.SaveChanges();
            return numberOfChanges != 0;
        }

        public bool TryUpdate(int studentToUpdateId, Student updated)
        {
            var toUpdate = GetStudent(studentToUpdateId);

            if (toUpdate == null)
                return false;
            
            toUpdate.Sex = updated.Sex;
            toUpdate.Name = updated.Name;
            toUpdate.LastName = updated.LastName;
            toUpdate.DateOfBirth = updated.DateOfBirth;
            toUpdate.SchoolClass = updated.SchoolClass;
            toUpdate.BorrowEvents = updated.BorrowEvents;

            _context.SaveChanges();
            return true;
        }
    }
}
