using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddedBibleBookList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookList",
                table: "BibleVersions");

            migrationBuilder.AddColumn<Guid>(
                name: "BibleBookListId",
                table: "BibleVersions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BibleBookListId1",
                table: "BibleVersions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BibleBookLists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BibleVersionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookList = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BibleBookLists", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BibleVersions_BibleBookListId1",
                table: "BibleVersions",
                column: "BibleBookListId1");

            migrationBuilder.AddForeignKey(
                name: "FK_BibleVersions_BibleBookLists_BibleBookListId1",
                table: "BibleVersions",
                column: "BibleBookListId1",
                principalTable: "BibleBookLists",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BibleVersions_BibleBookLists_BibleBookListId1",
                table: "BibleVersions");

            migrationBuilder.DropTable(
                name: "BibleBookLists");

            migrationBuilder.DropIndex(
                name: "IX_BibleVersions_BibleBookListId1",
                table: "BibleVersions");

            migrationBuilder.DropColumn(
                name: "BibleBookListId",
                table: "BibleVersions");

            migrationBuilder.DropColumn(
                name: "BibleBookListId1",
                table: "BibleVersions");

            migrationBuilder.AddColumn<string>(
                name: "BookList",
                table: "BibleVersions",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
