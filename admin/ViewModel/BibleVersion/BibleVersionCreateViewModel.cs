using Microsoft.AspNetCore.Mvc.Rendering;

namespace Admin.ViewModel.BibleVersion
{
    public class BibleVersionCreateViewModel
    {
        public required string Table { get; set; }
        public required string Abbreviation { get; set; }
        public required string Language { get; set; }
        public required string Version { get; set; }
        public string? InfoText { get; set; }
        public string? InfoURL { get; set; }
        public string? Publisher { get; set; }
        public string? Copyright { get; set; }
        public string? CopyrightInfo { get; set; }
        public Guid? BookListSource { get; set; }
        public List<SelectListItem>? BookListSources { get; set; }
    }
}
