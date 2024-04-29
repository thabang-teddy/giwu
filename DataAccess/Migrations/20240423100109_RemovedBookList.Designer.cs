﻿// <auto-generated />
using System;
using DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240423100109_RemovedBookList")]
    partial class RemovedBookList
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataAccess.Models.BibleVerse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<Guid>("BibleVersionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Book")
                        .HasColumnType("int");

                    b.Property<int>("Chapter")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Verse")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BibleVersionId");

                    b.ToTable("BibleVerses");
                });

            modelBuilder.Entity("DataAccess.Models.BibleVersion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Abbreviation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookList")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Copyright")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CopyrightInfo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InfoText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InfoURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Table")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Version")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BibleVersions");
                });

            modelBuilder.Entity("DataAccess.Models.BibleVerse", b =>
                {
                    b.HasOne("DataAccess.Models.BibleVersion", "BibleVersion")
                        .WithMany("BibleVerses")
                        .HasForeignKey("BibleVersionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BibleVersion");
                });

            modelBuilder.Entity("DataAccess.Models.BibleVersion", b =>
                {
                    b.Navigation("BibleVerses");
                });
#pragma warning restore 612, 618
        }
    }
}