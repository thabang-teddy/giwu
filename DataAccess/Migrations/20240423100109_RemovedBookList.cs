using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RemovedBookList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BibleBookLists");

            migrationBuilder.AddColumn<string>(
                name: "BookList",
                table: "BibleVersions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookList",
                table: "BibleVersions");

            migrationBuilder.CreateTable(
                name: "BibleBookLists",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BibleVersionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookList = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BibleBookLists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BibleBookLists_BibleVersions_BibleVersionId",
                        column: x => x.BibleVersionId,
                        principalTable: "BibleVersions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BibleBookLists_BibleVersionId",
                table: "BibleBookLists",
                column: "BibleVersionId");
        }
    }
}
