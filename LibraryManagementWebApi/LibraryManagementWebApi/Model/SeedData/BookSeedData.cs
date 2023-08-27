using LibraryManagementWebApi.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementWebApi.Model.SeedData
{
    public class BookSeedData : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book
                {
                    Id = 1,
                    BookName = "python",
                    AuthorId = 1,
                    Genre= "educational"
                },
                new Book
                {
                    Id = 2,
                    BookName = "Node",
                    AuthorId = 2,
                    Genre = "educational"
                },
              new Book
              {
                  Id = 3,
                  BookName = "C#",
                  AuthorId = 3,
                  Genre = "educational"
              }
              );
        }
    }
}
