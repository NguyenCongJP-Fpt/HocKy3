﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicWebDemo.Models;

namespace MusicWebDemo.Migrations
{
    [DbContext(typeof(MusicContext))]
    [Migration("20181120120436_MyDbContext")]
    partial class MyDbContext
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MusicWebDemo.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("Thumbnail");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MusicWebDemo.Models.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Link");

                    b.Property<string>("Name");

                    b.Property<string>("Singer");

                    b.Property<int>("Status");

                    b.Property<string>("Thumbnail");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("Id");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("MusicWebDemo.Models.SongCategory", b =>
                {
                    b.Property<int>("SongId");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Category");

                    b.Property<string>("Song");

                    b.HasKey("SongId", "CategoryId");

                    b.ToTable("SongCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
