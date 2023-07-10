using BookRecommendation.Core.Repositories;
using BookRecommendation.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecommendation.Service.Services
{
    public class BookOfTheDayService : GenericService<BookOfTheDay>
    {
        public BookOfTheDayService(IGenericRepository<BookOfTheDay> repository) : base(repository)
        {
        }
    }
}
