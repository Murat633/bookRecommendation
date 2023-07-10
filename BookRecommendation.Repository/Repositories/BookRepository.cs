using BookRecommendation.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecommendation.Repository.Repositories
{
    public class BookRepository : GenericRepository<Book>
    {
        public BookRepository(DbContext context) : base(context)
        {
        }
    }
}
