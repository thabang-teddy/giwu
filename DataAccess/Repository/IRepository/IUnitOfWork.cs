using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IBibleBookListRepository BibleBookLists { get; }
        IBibleVersionRepository BibleVersions { get; }
        IBibleVerseRepository BibleVerses { get; }

        void Save();
    }
}
