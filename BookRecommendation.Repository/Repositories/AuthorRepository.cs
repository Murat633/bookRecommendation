using BookRecommendation.Core.Repositories;
using BookRecommendation.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecommendation.Repository.Repositories
{
    public class AuthorRepository : GenericRepository<Author>,IAuthorRepository
    {
        public AuthorRepository(DbContext context) : base(context)
        {
        }
    }
}
