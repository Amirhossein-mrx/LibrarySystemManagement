using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagementWebApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "AuthorName" },
                values: new object[,]
                {
                    { 1, "amir" },
                    { 2, "ali" },
                    { 3, "reza" }
                });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "aa" },
                    { 2, "bb" },
                    { 3, "cc" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "PublisherName" },
                values: new object[,]
                {
                    { 1, "gaj" },
                    { 2, "sharif" },
                    { 3, "harfeaghar" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BookName", "Genre" },
                values: new object[] { 1, 1, "python", "educational" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BookName", "Genre" },
                values: new object[] { 2, 2, "Node", "educational" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BookName", "Genre" },
                values: new object[] { 3, 3, "C#", "educational" });

            migrationBuilder.InsertData(
                table: "BookInPublishers",
                columns: new[] { "Id", "BookId", "PublisherId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "BorrowingHistorys",
                columns: new[] { "Id", "BookId", "BorrowId", "DeliveryDate", "ReturnDate" },
                values: new object[,]
                {
                    { 1, 2, 1, new DateTime(2023, 8, 22, 17, 0, 17, 628, DateTimeKind.Local).AddTicks(3108), new DateTime(2023, 8, 22, 17, 0, 17, 648, DateTimeKind.Local).AddTicks(3851) },
                    { 2, 2, 3, new DateTime(2023, 8, 22, 17, 0, 17, 648, DateTimeKind.Local).AddTicks(5028), new DateTime(2023, 8, 22, 17, 0, 17, 648, DateTimeKind.Local).AddTicks(5046) },
                    { 3, 3, 1, new DateTime(2023, 8, 22, 17, 0, 17, 648, DateTimeKind.Local).AddTicks(5051), new DateTime(2023, 8, 22, 17, 0, 17, 648, DateTimeKind.Local).AddTicks(5054) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookInPublishers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookInPublishers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookInPublishers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BorrowingHistorys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BorrowingHistorys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BorrowingHistorys",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publishers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
