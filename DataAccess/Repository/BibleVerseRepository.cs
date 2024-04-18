using DataAccess.Data;
using DataAccess.Models;
using DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    internal class Repository
    {
    }
    public class BibleVerseRepository : Repository<BibleVerse>, IBibleVerseRepository
    {
        private ApplicationDbContext _db;
        public BibleVerseRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(BibleVerse obj)
        {
            _db.BibleVerses.Update(obj);
        }
    }
}
