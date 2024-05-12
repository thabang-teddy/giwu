using Microsoft.EntityFrameworkCore;
using DataAccess.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Reflection;

namespace DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<BibleVersion> BibleVersions { get; set; }
        public DbSet<ASVBibleVerse> ASV { get; set; }
        public DbSet<BBEBibleVerse> BBE { get; set; }
        public DbSet<DARBYBibleVerse> DARBY { get; set; }
        public DbSet<KJVBibleVerse> KJV { get; set; }
        public DbSet<WBTBibleVerse> WBT { get; set; }
        public DbSet<WEBBibleVerse> WEB { get; set; }
        public DbSet<YLTBibleVerse> YLT { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}

