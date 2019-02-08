﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Library.Data.Entities;
using Library.Data.Entities.Models;
using Library.Data.Enums;

namespace Library.Domain.Repositories
{
    public class AuthorRepository
    {
        private readonly LibraryContext _context;

        public AuthorRepository()
        {
            _context = new LibraryContext();
        }

        public ICollection<Author> GetAllAuthors()
        {
            return _context.Authors.ToList();
        }

        public Author GetAuthor(int toGetId)
        {
            return _context.Authors.Find(toGetId);
        }

        public void AddAuthor(Author toAdd)
        {
            _context.Authors.Add(toAdd);
            _context.SaveChanges();
        }

        public bool TryDelete(Author toDelete)
        {
            _context.Authors.Remove(toDelete);
            var numberOfChanges = _context.SaveChanges();
            return numberOfChanges != 0;
        }

        public bool TryUpdate(Author toUpdate, Author updated)
        {
            var tmpToUpdate = GetAllAuthors().FirstOrDefault(author => author.ToString() == toUpdate.ToString());

            if (tmpToUpdate == null)
                return false;
            
            tmpToUpdate.Name = updated.Name;
            tmpToUpdate.LastName = updated.LastName;

            var numberOfChanges = _context.SaveChanges();
            return numberOfChanges != 0;
        }
    }
}
