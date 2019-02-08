using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
