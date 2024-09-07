using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class BibleBookList
    {
        [Key]
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? BookList { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public List<BibleVersion> BibleVersions { get; set; } = new List<BibleVersion>();
    }
}
