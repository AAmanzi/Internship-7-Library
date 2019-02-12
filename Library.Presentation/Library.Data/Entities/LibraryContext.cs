using Library.Data.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Library.Data.Entities
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCopy> BookCopies { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<BorrowEvent> BorrowEvents { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["LibraryDatabase"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BorrowEvent>()
                .HasOne(borrowEvent => borrowEvent.BookCopy)
                .WithMany(bookCopy => bookCopy.BorrowEvents)
                .HasForeignKey(borrowEvent => borrowEvent.BookCopyId);
            modelBuilder.Entity<BorrowEvent>()
                .HasOne(borrowEvent => borrowEvent.Student)
                .WithMany(student => student.BorrowEvents)
                .HasForeignKey(borrowEvent => borrowEvent.StudentId);
        }
    }
}
