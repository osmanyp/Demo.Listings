using Demo.Listings.Infrastructure.DataAccess.EF.Entities;
using Microsoft.EntityFrameworkCore;

namespace Demo.Listings.Infrastructure.DataAccess
{
    internal class ListingsDbContext : DbContext
    {
        private string DbPath { get; }

        public DbSet<Listing> Listings { get; set; }

        public ListingsDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "listings.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Listing>().HasData(
                SeedData.GetSeedData()
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}