using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IBibleVersionRepository BibleVersions { get; }
        IBibleBookListRepository BibleBookLists { get; }
        IBibleVerseRepository BibleVerses { get; }

        void Save();
    }
}
