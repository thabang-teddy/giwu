﻿namespace Admin.ViewModel.BibleBookList
{
    public class BibleBookListDetailsViewModel
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? BookList { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
