﻿// <auto-generated />
using Fall2022_APIWorkshop;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fall2022_APIWorkshop.Migrations
{
    [DbContext(typeof(VideoGameContext))]
    [Migration("20220927171627_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Fall2022_APIWorkshop.Models.VideoGame", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("MainCharacter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Studio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VideoGames");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MainCharacter = "Mario",
                            Studio = "Nintendo",
                            Title = "Super Mario Brothers"
                        },
                        new
                        {
                            Id = 2,
                            MainCharacter = "Kirby",
                            Studio = "Hal Laboratories",
                            Title = "Kirby: Nightmare in Dreamland"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
