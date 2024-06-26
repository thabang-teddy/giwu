namespace DataAccess.ViewModel.BibleView
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

        public List<BibleDetailsBookListViewModel> BibleBookLists { get; set; } = new List<BibleDetailsBookListViewModel>();
    }
    public class BibleDetailsBookListViewModel
    {
        public int b { get; set; }
        public int c { get; set; }
        public required string n { get; set; }
        public required string t { get; set; }
        public int g { get; set; }
    }
    public class BibleVerseViewModel
    {
        public int Verse { get; set; }
        public required string Text { get; set; }
    }
    public class ChapterRequestViewModel
    {
        public string? Bible { get; set; }
        public int Book { get; set; }
        public int Chapter { get; set; }
    }
}
