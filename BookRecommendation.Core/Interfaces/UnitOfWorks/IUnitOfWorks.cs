using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRecommendation.Core.Interfaces.UnitOfWorks
{
    public interface IUnitOfWorks
    {
        public void SaveChangesAsync();
        public void SaveChanges();

    }
}
