using BookRecommendation.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecommendation.Repository
{
    public class EfDbContext:DbContext
    {
        public EfDbContext():base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookRecommendationDB;Integrated Security=True;")
        {
            
        }

        public DbSet<Author> Authors {  get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookOfTheDay> BookOfTheDay { get; set;}
        public DbSet<Category> Categories { get; set; }
    }
}
