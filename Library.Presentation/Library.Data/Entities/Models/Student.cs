using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Enums;

namespace Library.Data.Entities.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Sex Sex { get; set; }
        public SchoolClass SchoolClass { get; set; }

        public ICollection<BorrowEvent> BorrowEvents { get; set; }

        public Student(string name, string lastName, DateTime dateOfBirth, Sex sex, SchoolClass schoolClass)
        {
            Name = name;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Sex = sex;
            SchoolClass = schoolClass;
        }

        public override string ToString()
        {
            return $"{Name} {LastName} - {SchoolClass}";
        }
    }
}
