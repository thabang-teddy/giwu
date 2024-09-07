using DataAccess.Data;
using DataAccess.Models;
using DataAccess.Repository.IRepository;

namespace DataAccess.Repository
{
    public class BibleVersionRepository : Repository<BibleVersion>, IBibleVersionRepository
    {
        private ApplicationDbContext _db;
        public BibleVersionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(BibleVersion obj)
        {
            _db.BibleVersions.Update(obj);
        }
    }
}
