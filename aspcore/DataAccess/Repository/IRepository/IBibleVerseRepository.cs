﻿using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.IRepository
{
    public interface IBibleVerseRepository
    {
        List<BibleVerse>? GetChapterVerses(string tableName,int book, int chapter);
    }
}