using DataAccess.Data;
using DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public IBibleVersionRepository BibleVersions { get; private set; }
        public IBibleVerseRepository BibleVerses { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            BibleVersions = new BibleVersionRepository(_db);
            BibleVerses = new BibleVerseRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
