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
