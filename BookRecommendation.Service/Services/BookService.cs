using BookRecommendation.Core.Repositories;
using BookRecommendation.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecommendation.Service.Services
{
    public class BookService : GenericService<Book>
    {
        public BookService(IGenericRepository<Book> repository) : base(repository)
        {
        }
    }
}
