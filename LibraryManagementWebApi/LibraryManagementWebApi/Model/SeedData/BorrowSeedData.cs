using LibraryManagementWebApi.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LibraryManagementWebApi.Model.SeedData
{
    public class BorrowSeedData : IEntityTypeConfiguration<Borrow>
    {
        public void Configure(EntityTypeBuilder<Borrow> builder)
        {
            builder.HasData(
                new Borrow
                {
                    Id = 1,
                    UserName = "Ahmadi",
                },
                new Borrow
                {
                    Id = 2,
                    UserName = "Moradi",
                },
                  new Borrow
                  {
                      Id = 3,
                      UserName = "Mirzai",
                  }
                  );
        }
    }
    }
