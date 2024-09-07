using DataAccess.Data;
using DataAccess.Repository.IRepository;

namespace DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;
        public IBibleVersionRepository BibleVersions { get; private set; }
        public IBibleBookListRepository BibleBookLists { get; private set; }
        public IBibleVerseRepository BibleVerses { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            BibleVersions = new BibleVersionRepository(_db);
            BibleBookLists = new BibleBookListRepository(_db);
            BibleVerses = new BibleVerseRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
