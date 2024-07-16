using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedBibleBookListRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BibleVersions_BibleBookLists_BibleBookListId1",
                table: "BibleVersions");

            migrationBuilder.DropIndex(
                name: "IX_BibleVersions_BibleBookListId1",
                table: "BibleVersions");

            migrationBuilder.DropColumn(
                name: "BibleBookListId1",
                table: "BibleVersions");

            migrationBuilder.DropColumn(
                name: "BibleVersionId",
                table: "BibleBookLists");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "BibleBookLists",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpatedDate",
                table: "BibleBookLists",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "BibleBookLists",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BibleVersions_BibleBookListId",
                table: "BibleVersions",
                column: "BibleBookListId");

            migrationBuilder.AddForeignKey(
                name: "FK_BibleVersions_BibleBookLists_BibleBookListId",
                table: "BibleVersions",
                column: "BibleBookListId",
                principalTable: "BibleBookLists",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BibleVersions_BibleBookLists_BibleBookListId",
                table: "BibleVersions");

            migrationBuilder.DropIndex(
                name: "IX_BibleVersions_BibleBookListId",
                table: "BibleVersions");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "BibleBookLists");

            migrationBuilder.DropColumn(
                name: "LastUpatedDate",
                table: "BibleBookLists");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "BibleBookLists");

            migrationBuilder.AddColumn<Guid>(
                name: "BibleBookListId1",
                table: "BibleVersions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "BibleVersionId",
                table: "BibleBookLists",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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
    }
}
