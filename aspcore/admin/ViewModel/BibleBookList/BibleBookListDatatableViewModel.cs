namespace Admin.ViewModel.BibleBookList
{
    public class BibleBookListDatatableViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? BookList { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
