using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ASV",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Book = table.Column<int>(type: "int", nullable: false),
                    Chapter = table.Column<int>(type: "int", nullable: false),
                    Verse = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASV", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BBE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Book = table.Column<int>(type: "int", nullable: false),
                    Chapter = table.Column<int>(type: "int", nullable: false),
                    Verse = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BBE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BibleVersions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Table = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfoText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InfoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Copyright = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CopyrightInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookList = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BibleVersions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DARBY",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Book = table.Column<int>(type: "int", nullable: false),
                    Chapter = table.Column<int>(type: "int", nullable: false),
                    Verse = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DARBY", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KJV",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Book = table.Column<int>(type: "int", nullable: false),
                    Chapter = table.Column<int>(type: "int", nullable: false),
                    Verse = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KJV", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WBT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Book = table.Column<int>(type: "int", nullable: false),
                    Chapter = table.Column<int>(type: "int", nullable: false),
                    Verse = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WBT", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WEB",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Book = table.Column<int>(type: "int", nullable: false),
                    Chapter = table.Column<int>(type: "int", nullable: false),
                    Verse = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WEB", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "YLT",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Book = table.Column<int>(type: "int", nullable: false),
                    Chapter = table.Column<int>(type: "int", nullable: false),
                    Verse = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YLT", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ASV");

            migrationBuilder.DropTable(
                name: "BBE");

            migrationBuilder.DropTable(
                name: "BibleVersions");

            migrationBuilder.DropTable(
                name: "DARBY");

            migrationBuilder.DropTable(
                name: "KJV");

            migrationBuilder.DropTable(
                name: "WBT");

            migrationBuilder.DropTable(
                name: "WEB");

            migrationBuilder.DropTable(
                name: "YLT");
        }
    }
}
