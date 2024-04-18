using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class BibleBookList
    {
        public Guid Id { get; set; }
        public Guid BibleVersionId { get; set; }
        public required string BookList { get; set; }

        public BibleVersion? BibleVersion { get; set; }
    }
}
