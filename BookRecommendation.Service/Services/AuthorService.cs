using BookRecommendation.Core.Repositories;
using BookRecommendation.Core.Services;
using BookRecommendation.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecommendation.Service.Services
{
    public class AuthorService : GenericService<Author>, IAuthorService
    {
        public AuthorService(IGenericRepository<Author> repository) : base(repository)
        {
        }
    }
}
