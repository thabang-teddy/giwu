using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<BibleBookList> BibleBookLists { get; set; }
        public DbSet<BibleVersion> BibleVersions { get; set; }
        public DbSet<BibleVerse> BibleVerses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
