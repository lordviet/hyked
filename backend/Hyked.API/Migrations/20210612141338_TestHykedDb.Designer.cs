﻿// <auto-generated />
using System;
using Hyked.API.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hyked.API.Migrations
{
    [DbContext(typeof(HykedContext))]
    [Migration("20210612141338_TestHykedDb")]
    partial class TestHykedDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("17114131")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hyked.API.Entities.CarMeta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTimeOffset>("LastModifiedUtc")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("PassengerSeats")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Space gray",
                            LastModifiedUtc = new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 532, DateTimeKind.Unspecified).AddTicks(5506), new TimeSpan(0, 0, 0, 0, 0)),
                            Manufacturer = "Benz",
                            Model = "XLS",
                            PassengerSeats = 4,
                            UserId = 1,
                            Year = 2020
                        },
                        new
                        {
                            Id = 2,
                            Color = "Panda",
                            LastModifiedUtc = new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 532, DateTimeKind.Unspecified).AddTicks(6415), new TimeSpan(0, 0, 0, 0, 0)),
                            Manufacturer = "BMW",
                            Model = "X6",
                            PassengerSeats = 3,
                            UserId = 2,
                            Year = 2018
                        },
                        new
                        {
                            Id = 3,
                            Color = "Blue",
                            LastModifiedUtc = new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 532, DateTimeKind.Unspecified).AddTicks(6426), new TimeSpan(0, 0, 0, 0, 0)),
                            Manufacturer = "Audi",
                            Model = "A3",
                            PassengerSeats = 4,
                            UserId = 3,
                            Year = 2013
                        });
                });

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

            modelBuilder.Entity("Hyked.API.Entities.Trip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AvailableSeats")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("DepartureTimeUtc")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("FromLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset>("LastModifiedUtc")
                        .HasColumnType("datetimeoffset");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("TakenSeats")
                        .HasColumnType("int");

                    b.Property<string>("ToLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AvailableSeats = 3,
                            DepartureTimeUtc = new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 533, DateTimeKind.Unspecified).AddTicks(1857), new TimeSpan(0, 0, 0, 0, 0)),
                            FromLocation = "Sofia",
                            IsActive = true,
                            LastModifiedUtc = new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 533, DateTimeKind.Unspecified).AddTicks(5130), new TimeSpan(0, 0, 0, 0, 0)),
                            Price = 8.0,
                            TakenSeats = 0,
                            ToLocation = "Karlovo",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            AvailableSeats = 3,
                            DepartureTimeUtc = new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 533, DateTimeKind.Unspecified).AddTicks(6013), new TimeSpan(0, 0, 0, 0, 0)),
                            FromLocation = "Karlovo",
                            IsActive = false,
                            LastModifiedUtc = new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 533, DateTimeKind.Unspecified).AddTicks(6023), new TimeSpan(0, 0, 0, 0, 0)),
                            Price = 8.0,
                            TakenSeats = 0,
                            ToLocation = "Sofia",
                            UserId = 1
                        },
                        new
                        {
                            Id = 3,
                            AvailableSeats = 2,
                            DepartureTimeUtc = new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 533, DateTimeKind.Unspecified).AddTicks(6027), new TimeSpan(0, 0, 0, 0, 0)),
                            FromLocation = "Haskovo",
                            IsActive = false,
                            LastModifiedUtc = new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 533, DateTimeKind.Unspecified).AddTicks(6030), new TimeSpan(0, 0, 0, 0, 0)),
                            Price = 10.5,
                            TakenSeats = 2,
                            ToLocation = "Plovdiv",
                            UserId = 2
                        },
                        new
                        {
                            Id = 4,
                            AvailableSeats = 4,
                            DepartureTimeUtc = new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 533, DateTimeKind.Unspecified).AddTicks(6033), new TimeSpan(0, 0, 0, 0, 0)),
                            FromLocation = "Sofia",
                            IsActive = true,
                            LastModifiedUtc = new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 533, DateTimeKind.Unspecified).AddTicks(6036), new TimeSpan(0, 0, 0, 0, 0)),
                            Price = 20.0,
                            TakenSeats = 2,
                            ToLocation = "Varna",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("Hyked.API.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("LastModifiedUtc")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LastModifiedUtc = new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 531, DateTimeKind.Unspecified).AddTicks(6878), new TimeSpan(0, 0, 0, 0, 0)),
                            Password = "password",
                            PhoneNumber = "0878501743",
                            Username = "lordviet"
                        },
                        new
                        {
                            Id = 2,
                            LastModifiedUtc = new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 531, DateTimeKind.Unspecified).AddTicks(8017), new TimeSpan(0, 0, 0, 0, 0)),
                            Password = "password",
                            PhoneNumber = "0878503131",
                            Username = "nix"
                        },
                        new
                        {
                            Id = 3,
                            LastModifiedUtc = new DateTimeOffset(new DateTime(2021, 6, 12, 14, 13, 37, 531, DateTimeKind.Unspecified).AddTicks(8028), new TimeSpan(0, 0, 0, 0, 0)),
                            Password = "password",
                            PhoneNumber = "0878504141",
                            Username = "virgo"
                        });
                });

            modelBuilder.Entity("Hyked.API.Entities.CarMeta", b =>
                {
                    b.HasOne("Hyked.API.Entities.User", "Owner")
                        .WithOne("Car")
                        .HasForeignKey("Hyked.API.Entities.CarMeta", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");
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

            modelBuilder.Entity("Hyked.API.Entities.Trip", b =>
                {
                    b.HasOne("Hyked.API.Entities.User", "Driver")
                        .WithMany("Trips")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("Hyked.API.Entities.City", b =>
                {
                    b.Navigation("PointsOfInterest");
                });

            modelBuilder.Entity("Hyked.API.Entities.User", b =>
                {
                    b.Navigation("Car");

                    b.Navigation("Trips");
                });
#pragma warning restore 612, 618
        }
    }
}
