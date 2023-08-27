using LibraryManagementWebApi.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementWebApi.Model.SeedData
{
    public class PublisherSeedData : IEntityTypeConfiguration<Publisher>
        {
            public void Configure(EntityTypeBuilder<Publisher> builder)
            {
                builder.HasData(
                    new Publisher
                    {
                        Id = 1,
                        PublisherName = "gaj"
                    },
                    new Publisher
                    {
                        Id = 2,
                        PublisherName = "sharif"
                    },
                      new Publisher
                      {
                          Id = 3,
                          PublisherName = "harfeaghar"
                      }
                      );
            }
        }
    }
