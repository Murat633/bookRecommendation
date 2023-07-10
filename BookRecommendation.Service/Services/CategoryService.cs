using BookRecommendation.Core.Repositories;
using BookRecommendation.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecommendation.Service.Services
{
    public class CategoryService : GenericService<Category>
    {
        public CategoryService(IGenericRepository<Category> repository) : base(repository)
        {
        }
    }
}
