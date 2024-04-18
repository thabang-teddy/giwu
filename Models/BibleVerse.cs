using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class BibleVerse
    {
        [Key]
        public int Id { get; set; }
        public Guid BibleVersionId { get; set; }
        public int Book { get; set; }
        public int Chapter { get; set; }
        public int Verse { get; set; }
        public required string Text { get; set; }

        public BibleVersion? BibleVersion { get; set; }
    }
}
