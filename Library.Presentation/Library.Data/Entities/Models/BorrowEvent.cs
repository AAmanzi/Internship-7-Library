using System;

namespace Library.Data.Entities.Models
{
    public class BorrowEvent
    {
        public int BorrowEventId { get; set; }
        public DateTime DateOfBorrow { get; set; }
        public DateTime? DateOfReturn { get; set; }

        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int BookCopyId { get; set; }
        public BookCopy BookCopy { get; set; }

        public BorrowEvent()
        {
            
        }

        public BorrowEvent(DateTime dateOfBorrow, DateTime? dateOfReturn, Student student, BookCopy bookCopy)
        {
            DateOfBorrow = dateOfBorrow;
            DateOfReturn = dateOfReturn;
            Student = student;
            BookCopy = bookCopy;
        }

        public override string ToString()
        {
            return $"{Student} {BookCopy}";
        }
    }
}
