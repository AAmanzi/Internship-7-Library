using System.Collections.Generic;
using System.Linq;
using Library.Data.Entities;
using Library.Data.Entities.Models;

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

        public bool AddStudent(Student toAdd)
        {
            _context.Students.Add(toAdd);
            var numberOfChanges = _context.SaveChanges();
            return numberOfChanges != 0;
        }

        public bool TryDelete(Student toDelete)
        {
            _context.Students.Remove(toDelete);
            var numberOfChanges = _context.SaveChanges();
            return numberOfChanges != 0;
        }

        public bool TryUpdate(Student toUpdate, Student updated)
        {
            var tmpToUpdate = GetAllStudents().FirstOrDefault(student => student.ToString() == toUpdate.ToString());

            if (tmpToUpdate == null)
                return false;
            
            tmpToUpdate.Sex = updated.Sex;
            tmpToUpdate.Name = updated.Name;
            tmpToUpdate.LastName = updated.LastName;
            tmpToUpdate.DateOfBirth = updated.DateOfBirth;
            tmpToUpdate.SchoolClass = updated.SchoolClass;

            var numberOfChanges = _context.SaveChanges();
            return numberOfChanges != 0;
        }
    }
}
