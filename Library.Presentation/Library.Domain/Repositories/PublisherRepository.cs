using System.Collections.Generic;
using System.Linq;
using Library.Data.Entities;
using Library.Data.Entities.Models;

namespace Library.Domain.Repositories
{
    public class PublisherRepository
    {
        private readonly LibraryContext _context;

        public PublisherRepository()
        {
            _context = new LibraryContext();
        }

        public ICollection<Publisher> GetAllPublishers()
        {
            return _context.Publishers.ToList();
        }

        public void AddPublisher(Publisher toAdd)
        {
            _context.Publishers.Add(toAdd);
            _context.SaveChanges();
        }

        public bool TryDelete(Publisher toDelete)
        {
            _context.Publishers.Remove(toDelete);
            var numberOfChanges = _context.SaveChanges();
            return numberOfChanges != 0;
        }

        public bool TryUpdate(Publisher toUpdate, Publisher updated)
        {
            var tmpToUpdate = GetAllPublishers().FirstOrDefault(publisher => publisher.ToString() == toUpdate.ToString());

            if (tmpToUpdate == null)
                return false;
            
            tmpToUpdate.Name = updated.Name;

            var numberOfChanges = _context.SaveChanges();
            return numberOfChanges != 0;
        }
    }
}
