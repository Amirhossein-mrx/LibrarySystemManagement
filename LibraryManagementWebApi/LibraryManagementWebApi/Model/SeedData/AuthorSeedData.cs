using LibraryManagementWebApi.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementWebApi.Model.SeedData
{
    public class AuthorSeedData : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(new Author
            {
                Id = 1,
                AuthorName = "amir"
            },
                new Author
                {
                    Id = 2,
                    AuthorName = "ali"
                },
                  new Author
                  {
                      Id = 3,
                      AuthorName = "reza"
                  }
                );
        }
    }
}
