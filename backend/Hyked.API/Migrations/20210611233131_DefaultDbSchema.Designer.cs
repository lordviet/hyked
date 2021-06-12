﻿// <auto-generated />
using Hyked.API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hyked.API.Migrations
{
    [DbContext(typeof(HykedContext))]
    [Migration("20210611233131_DefaultDbSchema")]
    partial class DefaultDbSchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("17114131")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hyked.API.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "The one where Spidey swings",
                            Name = "New York City"
                        },
                        new
                        {
                            Id = 2,
                            Description = "The one where Levski was born",
                            Name = "Karlovo"
                        },
                        new
                        {
                            Id = 3,
                            Description = "The one with the artsy stuff",
                            Name = "Paris"
                        });
                });

            modelBuilder.Entity("Hyked.API.Entities.PointOfInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("PointsOfInterest");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Description = "That big park",
                            Name = "Central Park"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Description = "The one in which the emperor lives",
                            Name = "Empire State Building"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 2,
                            Description = "A splashy beauty",
                            Name = "The waterfall"
                        });
                });

            modelBuilder.Entity("Hyked.API.Entities.PointOfInterest", b =>
                {
                    b.HasOne("Hyked.API.Entities.City", "City")
                        .WithMany("PointsOfInterest")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Hyked.API.Entities.City", b =>
                {
                    b.Navigation("PointsOfInterest");
                });
#pragma warning restore 612, 618
        }
    }
}