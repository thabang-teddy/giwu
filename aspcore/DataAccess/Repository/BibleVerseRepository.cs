using DataAccess.Data;
using DataAccess.Models;
using DataAccess.Repository.IRepository;
namespace DataAccess.Repository
{
    internal class Repository
    {
    }
    public class BibleVerseRepository : IBibleVerseRepository
    {
        private ApplicationDbContext _db;
        public BibleVerseRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public List<BibleVerse>? GetChapterVerses(string tableName, int book, int chapter)
        {
            List<BibleVerse> verses = new();

            if (tableName == "ASV")
            {
                var asvRowBibleVerses = _db.ASV.Where(x => x.Book == book && x.Chapter == chapter).ToList();
                verses = asvRowBibleVerses.Select(x => new BibleVerse {
                    Id = x.Id,
                    Book = x.Book,
                    Chapter = x.Chapter,
                    Verse = x.Verse,
                    Text = x.Text,
                }).ToList();
            }
            if (tableName == "BBE")
            {
                var bbeRowBibleVerses = _db.BBE.Where(x => x.Book == book && x.Chapter == chapter).ToList();
                verses = bbeRowBibleVerses.Select(x => new BibleVerse
                {
                    Id = x.Id,
                    Book = x.Book,
                    Chapter = x.Chapter,
                    Verse = x.Verse,
                    Text = x.Text,
                }).ToList();
            }
            if (tableName == "DARBY")
            {
                var darbyRowBibleVerses = _db.DARBY.Where(x => x.Book == book && x.Chapter == chapter).ToList();
                verses = darbyRowBibleVerses.Select(x => new BibleVerse
                {
                    Id = x.Id,
                    Book = x.Book,
                    Chapter = x.Chapter,
                    Verse = x.Verse,
                    Text = x.Text,
                }).ToList();
            }
            if (tableName == "KJV")
            {
                var kjvRowBibleVerses = _db.KJV.Where(x => x.Book == book && x.Chapter == chapter).ToList();
                verses = kjvRowBibleVerses.Select(x => new BibleVerse
                {
                    Id = x.Id,
                    Book = x.Book,
                    Chapter = x.Chapter,
                    Verse = x.Verse,
                    Text = x.Text,
                }).ToList();
            }
            if (tableName == "WBT")
            {
                var wbtRowBibleVerses = _db.WBT.Where(x => x.Book == book && x.Chapter == chapter).ToList();
                verses = wbtRowBibleVerses.Select(x => new BibleVerse
                {
                    Id = x.Id,
                    Book = x.Book,
                    Chapter = x.Chapter,
                    Verse = x.Verse,
                    Text = x.Text,
                }).ToList();
            }
            if (tableName == "WEB")
            {
                var webRowBibleVerses = _db.WEB.Where(x => x.Book == book && x.Chapter == chapter).ToList();
                verses = webRowBibleVerses.Select(x => new BibleVerse
                {
                    Id = x.Id,
                    Book = x.Book,
                    Chapter = x.Chapter,
                    Verse = x.Verse,
                    Text = x.Text,
                }).ToList();
            }
            if (tableName == "YLT")
            {
                var yltRowBibleVerses = _db.YLT.Where(x => x.Book == book && x.Chapter == chapter).ToList();
                verses = yltRowBibleVerses.Select(x => new BibleVerse
                {
                    Id = x.Id,
                    Book = x.Book,
                    Chapter = x.Chapter,
                    Verse = x.Verse,
                    Text = x.Text,
                }).ToList();
            }

            return verses;
        }

    }
}
