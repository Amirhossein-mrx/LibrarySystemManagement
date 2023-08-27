using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagementWebApi.Migrations
{
    public partial class EditBorrowInPublisher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookInPublishers_Publishers_PublishersId",
                table: "BookInPublishers");

            migrationBuilder.DropIndex(
                name: "IX_BookInPublishers_PublishersId",
                table: "BookInPublishers");

            migrationBuilder.DropColumn(
                name: "PublishersId",
                table: "BookInPublishers");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "BookInPublishers",
                newName: "PublisherId");

            migrationBuilder.CreateIndex(
                name: "IX_BookInPublishers_PublisherId",
                table: "BookInPublishers",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookInPublishers_Publishers_PublisherId",
                table: "BookInPublishers",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookInPublishers_Publishers_PublisherId",
                table: "BookInPublishers");

            migrationBuilder.DropIndex(
                name: "IX_BookInPublishers_PublisherId",
                table: "BookInPublishers");

            migrationBuilder.RenameColumn(
                name: "PublisherId",
                table: "BookInPublishers",
                newName: "AuthorId");

            migrationBuilder.AddColumn<int>(
                name: "PublishersId",
                table: "BookInPublishers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookInPublishers_PublishersId",
                table: "BookInPublishers",
                column: "PublishersId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookInPublishers_Publishers_PublishersId",
                table: "BookInPublishers",
                column: "PublishersId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
