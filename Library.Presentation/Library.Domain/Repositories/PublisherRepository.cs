﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public Publisher GetPublisher(int toGetId)
        {
            return _context.Publishers.Find(toGetId);
        }

        public void AddPublisher(Publisher toAdd)
        {
            _context.Publishers.Add(toAdd);
            _context.SaveChanges();
        }

        public bool TryDelete(int toDeleteId)
        {
            var toDelete = GetPublisher(toDeleteId);
            if (toDelete == null)
                return false;
            _context.Publishers.Remove(toDelete);
            _context.SaveChanges();
            return true;
        }

        public bool TryUpdate(int publisherToUpdateId, Publisher updated)
        {
            var toUpdate = GetPublisher(publisherToUpdateId);

            if (toUpdate == null)
                return false;

            toUpdate.Name = updated.Name;

            _context.SaveChanges();
            return true;
        }
    }
}