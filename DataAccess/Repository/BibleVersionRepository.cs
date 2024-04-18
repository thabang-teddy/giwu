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
