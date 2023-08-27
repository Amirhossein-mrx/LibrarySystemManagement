using LibraryManagementWebApi.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementWebApi.Model.SeedData
{
    public class BookInPublisherSeedData : IEntityTypeConfiguration<BookInPublisher>
        {
            public void Configure(EntityTypeBuilder<BookInPublisher> builder)
            {

                builder.HasData(
                    new BookInPublisher
                    {
                        Id = 1,
                        BookId = 1,
                        PublisherId = 1
                    },
                    new BookInPublisher
                    {
                        Id = 2,
                        BookId = 2,
                        PublisherId = 2
                    },
                      new BookInPublisher
                      {
                          Id = 3,
                          BookId = 3,
                          PublisherId = 3
                      }
                      );
            }
        }
    }
