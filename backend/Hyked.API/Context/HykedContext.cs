using Hyked.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Hyked.API.Context
{
    public class HykedContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<CarMeta> Cars { get; set; }
        public DbSet<Trip> Trips { get; set; }

        public DbSet<Audit> log_17114131 { get; set; }

        public HykedContext(DbContextOptions<HykedContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seeding is used for providing the db with initial value to start
            modelBuilder.HasDefaultSchema("17114131");

            modelBuilder.Entity<City>().HasData(
                new City()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one where Spidey swings"
                },
                new City()
                {
                    Id = 2,
                    Name = "Karlovo",
                    Description = "The one where Levski was born"
                },
                new City()
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "The one with the artsy stuff"
                });

            modelBuilder.Entity<PointOfInterest>().HasData(
                new PointOfInterest()
                {
                    Id = 1,
                    CityId = 1,
                    Name = "Central Park",
                    Description = "That big park"
                },
                new PointOfInterest()
                {
                    Id = 2,
                    CityId = 1,
                    Name = "Empire State Building",
                    Description = "The one in which the emperor lives"
                },
                new PointOfInterest()
                {
                    Id = 3,
                    CityId = 2,
                    Name = "The waterfall",
                    Description = "A splashy beauty"
                });

            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Username = "lordviet",
                    Password = "password",
                    PhoneNumber = "0878501743",
                    LastModifiedUtc = DateTime.UtcNow
                },
                new User()
                {
                    Id = 2,
                    Username = "nix",
                    Password = "password",
                    PhoneNumber = "0878503131",
                    LastModifiedUtc = DateTime.UtcNow
                },
                new User()
                {
                    Id = 3,
                    Username = "virgo",
                    Password = "password",
                    PhoneNumber = "0878504141",
                    LastModifiedUtc = DateTime.UtcNow
                },
                new User()
                {
                    Id = 4,
                    Username = "Baby mama",
                    Password = "password",
                    PhoneNumber = "0878504141",
                    LastModifiedUtc = DateTime.UtcNow
                }
            );

            modelBuilder.Entity<CarMeta>().HasData(
                new CarMeta()
                {
                    Id = 1,
                    UserId = 1,
                    Manufacturer = "Benz",
                    Model = "XLS",
                    Year = 2020,
                    Color = "Space gray",
                    PassengerSeats = 4,
                    LastModifiedUtc = DateTime.UtcNow
                },
                new CarMeta()
                {
                    Id = 2,
                    UserId = 2,
                    Manufacturer = "BMW",
                    Model = "X6",
                    Year = 2018,
                    Color = "Panda",
                    PassengerSeats = 3,
                    LastModifiedUtc = DateTime.UtcNow
                },
                new CarMeta()
                {
                    Id = 3,
                    UserId = 3,
                    Manufacturer = "Audi",
                    Model = "A3",
                    Year = 2013,
                    Color = "Blue",
                    PassengerSeats = 4,
                    LastModifiedUtc = DateTime.UtcNow
                }
            );

            modelBuilder.Entity<Trip>().HasData(
                new Trip()
                {
                    Id = 1,
                    UserId = 1,
                    FromLocation = "Sofia",
                    ToLocation = "Karlovo",
                    Price = 8,
                    DepartureTimeUtc = DateTime.UtcNow,
                    AvailableSeats = 3,
                    TakenSeats = 0,
                    IsActive = true,
                    LastModifiedUtc = DateTime.UtcNow
                },
                new Trip()
                {
                    Id = 2,
                    UserId = 1,
                    FromLocation = "Karlovo",
                    ToLocation = "Sofia",
                    Price = 8,
                    DepartureTimeUtc = DateTime.UtcNow,
                    AvailableSeats = 3,
                    TakenSeats = 0,
                    IsActive = false,
                    LastModifiedUtc = DateTime.UtcNow
                },
                new Trip()
                {
                    Id = 3,
                    UserId = 2,
                    FromLocation = "Haskovo",
                    ToLocation = "Plovdiv",
                    Price = 10.50,
                    DepartureTimeUtc = DateTime.UtcNow,
                    AvailableSeats = 2,
                    TakenSeats = 2,
                    IsActive = false,
                    LastModifiedUtc = DateTime.UtcNow
                },
                new Trip()
                {
                    Id = 4,
                    UserId = 3,
                    FromLocation = "Sofia",
                    ToLocation = "Varna",
                    Price = 20,
                    DepartureTimeUtc = DateTime.UtcNow,
                    AvailableSeats = 4,
                    TakenSeats = 2,
                    IsActive = true,
                    LastModifiedUtc = DateTime.UtcNow
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
