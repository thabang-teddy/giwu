using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class BibleVerse
    {
        [Key]
        public int Id { get; set; }
        public int Book { get; set; }
        public int Chapter { get; set; }
        public int Verse { get; set; }
        public required string Text { get; set; }
    }

    public class ASVBibleVerse : BibleVerse {}
    public class BBEBibleVerse : BibleVerse {}
    public class DARBYBibleVerse : BibleVerse {}
    public class KJVBibleVerse : BibleVerse {}
    public class WBTBibleVerse : BibleVerse {}
    public class WEBBibleVerse : BibleVerse {}
    public class YLTBibleVerse : BibleVerse {}
}
