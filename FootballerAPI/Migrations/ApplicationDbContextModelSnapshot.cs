﻿// <auto-generated />
using System;
using ChessPlayerAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChessPlayerAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ChessPlayerAPI.Models.ChessPlayer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ELO")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ChessPlayers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1f5e8297-d50f-4151-a669-844425774a18"),
                            ELO = 2747,
                            Name = "Karjakin",
                            Nationality = "Russia"
                        },
                        new
                        {
                            Id = new Guid("58bf86d9-f836-46b7-b135-3d4904c6e1af"),
                            ELO = 2859,
                            Name = "Carlson",
                            Nationality = "Norway"
                        },
                        new
                        {
                            Id = new Guid("e7f102ad-002a-432d-930a-8c0bb735efd3"),
                            ELO = 2766,
                            Name = "Caruana",
                            Nationality = "USA"
                        });
                });

            modelBuilder.Entity("ChessPlayerAPI.Models.Record", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChessplayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChessplayerId");

                    b.ToTable("Records");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0ddf44be-403f-4645-93db-0f7a58bc35ce"),
                            ChessplayerId = new Guid("1f5e8297-d50f-4151-a669-844425774a18"),
                            Name = "Youngest Grand Master Ever"
                        },
                        new
                        {
                            Id = new Guid("01b4c394-cfe7-473e-99c8-7f4ae39654f0"),
                            ChessplayerId = new Guid("1f5e8297-d50f-4151-a669-844425774a18"),
                            Name = "Youngest International Master Ever"
                        },
                        new
                        {
                            Id = new Guid("0ad4d821-2455-49e6-bcad-7bce983a3097"),
                            ChessplayerId = new Guid("58bf86d9-f836-46b7-b135-3d4904c6e1af"),
                            Name = "Highest ELO ever achieved "
                        },
                        new
                        {
                            Id = new Guid("a8818418-d52d-4ea7-8390-97f9aaabd6b0"),
                            ChessplayerId = new Guid("58bf86d9-f836-46b7-b135-3d4904c6e1af"),
                            Name = "Longest unbeaten steak at elite level (125 games)"
                        },
                        new
                        {
                            Id = new Guid("b0bb7e69-0b83-4d1e-8af8-4945ddae1123"),
                            ChessplayerId = new Guid("e7f102ad-002a-432d-930a-8c0bb735efd3"),
                            Name = "Highest performance rating in an elite level tournament (3098 ELO)"
                        });
                });

            modelBuilder.Entity("ChessPlayerAPI.Models.Title", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ChessplayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ChessplayerId");

                    b.ToTable("Titles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0fb06218-e11b-4b0c-9ad3-2bb5e09ae0b9"),
                            ChessplayerId = new Guid("1f5e8297-d50f-4151-a669-844425774a18"),
                            Name = "World Rapid Champion 2012"
                        },
                        new
                        {
                            Id = new Guid("c7befc86-a065-41d7-8777-420aea641d13"),
                            ChessplayerId = new Guid("1f5e8297-d50f-4151-a669-844425774a18"),
                            Name = "World Blitz Champion 2016"
                        },
                        new
                        {
                            Id = new Guid("10ffc982-1807-4979-b1d2-5f5622b3a683"),
                            ChessplayerId = new Guid("58bf86d9-f836-46b7-b135-3d4904c6e1af"),
                            Name = "World Chess Champion"
                        },
                        new
                        {
                            Id = new Guid("90316a96-a678-49bd-a471-e9cd8c56bb72"),
                            ChessplayerId = new Guid("58bf86d9-f836-46b7-b135-3d4904c6e1af"),
                            Name = "World Rapid Chess Champion"
                        },
                        new
                        {
                            Id = new Guid("ce5e9a57-6ba7-4892-96aa-dbffe4ef833f"),
                            ChessplayerId = new Guid("e7f102ad-002a-432d-930a-8c0bb735efd3"),
                            Name = "US Chess Champion 2022"
                        });
                });

            modelBuilder.Entity("ChessPlayerAPI.Models.Record", b =>
                {
                    b.HasOne("ChessPlayerAPI.Models.ChessPlayer", "ChessPlayer")
                        .WithMany("Records")
                        .HasForeignKey("ChessplayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChessPlayer");
                });

            modelBuilder.Entity("ChessPlayerAPI.Models.Title", b =>
                {
                    b.HasOne("ChessPlayerAPI.Models.ChessPlayer", "ChessPlayer")
                        .WithMany("Titles")
                        .HasForeignKey("ChessplayerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChessPlayer");
                });

            modelBuilder.Entity("ChessPlayerAPI.Models.ChessPlayer", b =>
                {
                    b.Navigation("Records");

                    b.Navigation("Titles");
                });
#pragma warning restore 612, 618
        }
    }
}
