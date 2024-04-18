﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BibleVersion
    {
        public Guid Id { get; set; }
        [Required]
        public required string Table { get; set; }
        [Required]
        public required string Abbreviation { get; set; }
        [Required]
        public required string Language { get; set; }
        [Required]
        public required string Version { get; set; }
        public string? InfoText { get; set; }
        public string? InfoURL { get; set; }
        public string? Publisher { get; set; }
        public string? Copyright { get; set; }
        public string? CopyrightInfo { get; set; }

        public List<BibleBookList>? BibleBookLists { get; set; }
        public List<BibleVerse>? BibleVerses { get; set; }
    }
}
