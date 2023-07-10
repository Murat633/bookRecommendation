using BookRecommendation.Core.Interfaces.UnitOfWorks;
using BookRecommendation.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecommendation.Service.UnitOfWorks
{
    public class UnitOfWorks : IUnitOfWorks
    {
        public DbContext _context { get; set; }
        public UnitOfWorks(DbContext context )
        {
            _context = context;
        }

        public void SaveChangesAsync()
        {
            _context.SaveChangesAsync();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
