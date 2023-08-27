using LibraryManagementWebApi.Model.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace LibraryManagementWebApi.Model.SeedData
{
    public class BorrowingHistorySeedData : IEntityTypeConfiguration<BorrowingHistory>
        {
            public void Configure(EntityTypeBuilder<BorrowingHistory> builder)
            {
                builder.HasData(
                    new BorrowingHistory
                    {
                        Id = 1,
                        BookId = 2,
                        BorrowId = 1,
                        DeliveryDate = DateTime.Now,
                        ReturnDate = DateTime.Now,
                    },
                    new BorrowingHistory
                    {
                        Id = 2,
                        BookId = 2,
                        BorrowId = 3,
                        DeliveryDate = DateTime.Now,
                        ReturnDate = DateTime.Now,
                    },
                      new BorrowingHistory
                      {
                          Id = 3,
                          BookId = 3,
                          BorrowId = 1,
                          DeliveryDate = DateTime.Now,
                          ReturnDate = DateTime.Now,
                      }
                      );
            }
        }
    }
