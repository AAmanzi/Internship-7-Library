using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Entities.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return $"{Name} {LastName}";
        }
    }
}
