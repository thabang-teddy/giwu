using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IBibleVerseRepository : IRepository<BibleVerse>
    {
        void Update(BibleVerse obj);
    }
}
