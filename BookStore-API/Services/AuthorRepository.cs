using BookStore_API.Contracts;
using BookStore_API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore_API.Services
{
    public class AuthorRepository : IAuthorRepository
    {
        public Task<bool> Create(Author entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(Author entity)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Author>> FindAll()
        {
            throw new NotImplementedException();
        }

        public Task<Author> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Save()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}
