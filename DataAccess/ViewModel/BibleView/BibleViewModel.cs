using DataAccess.Models;
using System.ComponentModel.DataAnnotations;

namespace Admin.ViewModel.BibleView
{
    public class BibleVersionDatatableViewModel
    {
        public Guid Id { get; set; }
        public required string Abbreviation { get; set; }
        public required string Language { get; set; }
        public required string Version { get; set; }
        public string? InfoURL { get; set; }
        public string? Copyright { get; set; }
    }
    public class BibleVersionViewModel
    {
        public Guid Id { get; set; }
        public required string Table { get; set; }
        public required string Abbreviation { get; set; }
        public required string Language { get; set; }
        public required string Version { get; set; }
        public string? InfoText { get; set; }
        public string? InfoURL { get; set; }
        public string? Publisher { get; set; }
        public string? Copyright { get; set; }
        public string? CopyrightInfo { get; set; }

        public List<BibleDetailsBookListViewModel>? BibleBookLists { get; set; }
    }
    public class BibleDetailsBookListViewModel
    {
        public required string Name { get; set; }
        public int Book { get; set; }
        public required string Testament { get; set; }
        public int ChapterCount { get; set; }
    }
}
