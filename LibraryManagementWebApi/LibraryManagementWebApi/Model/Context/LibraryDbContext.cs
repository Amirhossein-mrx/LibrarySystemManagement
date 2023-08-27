using LibraryManagementWebApi.Model.Entity;
using LibraryManagementWebApi.Model.SeedData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementWebApi.Model.Context
{
    public class LibraryDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=172.18.176.74\\sana; Initial Catalog=AmirD;Integrated Security=true");
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new BookSeedData());
        //    modelBuilder.ApplyConfiguration(new AuthorSeedData());
        //    modelBuilder.ApplyConfiguration(new BorrowSeedData());
        //    modelBuilder.ApplyConfiguration(new BookInPublisherSeedData());
        //    modelBuilder.ApplyConfiguration(new PublisherSeedData());
        //    modelBuilder.ApplyConfiguration(new BorrowingHistorySeedData());
        //}

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Borrow> Borrows { get; set; }
        public DbSet<BookInPublisher> BookInPublishers { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<BorrowingHistory> BorrowingHistorys { get; set; }
    }
}
