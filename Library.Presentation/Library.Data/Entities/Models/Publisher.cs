using System.Collections.Generic;

namespace Library.Data.Entities.Models
{
    public class Publisher
    {
        public int PublisherId { get; set; }
        public string Name { get; set; }

        public ICollection<Book> Books { get; set; }

        public Publisher(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
