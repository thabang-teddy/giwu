using Microsoft.EntityFrameworkCore;
using DataAccess.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<BibleVersion> BibleVersions { get; set; }
        public DbSet<BibleVerse> BibleVerses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
