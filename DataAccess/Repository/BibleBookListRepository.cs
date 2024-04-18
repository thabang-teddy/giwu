using DataAccess.Data;
using DataAccess.Models;
using DataAccess.Repository.IRepository;

namespace DataAccess.Repository
{
    public class BibleBookListRepository : Repository<BibleBookList>, IBibleBookListRepository
    {
        private ApplicationDbContext _db;
        public BibleBookListRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(BibleBookList obj)
        {
            _db.BibleBookLists.Update(obj);
        }
    }
}
