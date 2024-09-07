namespace Admin.ViewModel.BibleBookList
{
    public class BibleBookListViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? BookList { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
    public class BibleBookListItemViewModel
    {
        public int b { get; set; }
        public int c { get; set; }
        public string? n { get; set; }
        public string? t { get; set; }
        public int g { get; set; }
    }
}
