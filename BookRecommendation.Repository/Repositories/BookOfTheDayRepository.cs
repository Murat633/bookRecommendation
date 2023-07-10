using BookRecommendation.Core.Repositories;
using BookRecommendation.Core.Services;
using BookRecommendation.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecommendation.Repository.Repositories
{
    public class BookOfTheDayRepository : GenericRepository<BookOfTheDay>, IBookOfTheDayRepository
    {
        public BookOfTheDayRepository(DbContext context) : base(context)
        {
        }
    }
}
