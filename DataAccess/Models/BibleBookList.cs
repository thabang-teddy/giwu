using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models
{
    public class BibleBookList
    {
        [Key]
        public Guid Id { get; set; }
        public Guid BibleVersionId { get; set; }
        public string? BookList { get; set; }
    }
}
