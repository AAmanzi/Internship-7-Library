using System.Collections.Generic;

namespace Library.Data.Entities.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public ICollection<Book> Books { get; set; }

        public Author()
        {
            
        }

        public Author(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"{Name} {LastName}";
        }
    }
}
