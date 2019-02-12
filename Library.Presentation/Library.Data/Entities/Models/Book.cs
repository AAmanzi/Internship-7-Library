using System.Collections.Generic;
using Library.Data.Enums;

namespace Library.Data.Entities.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public string PageCount { get; set; }
        public Genre Genre { get; set; }

        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<BookCopy> BookCopies { get; set; }

        public Book()
        {
            
        }

        public Book(string name, string pageCount, Genre genre, Author author, Publisher publisher)
        {
            Name = name;
            PageCount = pageCount;
            Genre = genre;
            Author = author;
            Publisher = publisher;
        }

        public override string ToString()
        {
            return $"{Name} - {Author} - {Publisher}";
        }
    }
}
