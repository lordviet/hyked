using Hyked.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Hyked.API.Context
{
    public class HykedContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<CarMeta> Cars { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<TripPassenger> TripPassengers { get; set; }

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

            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    Username = "lordviet",
                    Password = "password",
                    PhoneNumber = "0878501743",
                    LastModifiedUtc17114131 = DateTime.UtcNow
                },
                new User()
                {
                    Id = 2,
                    Username = "Hawkins",
                    Password = "password",
                    PhoneNumber = "0878503131",
                    LastModifiedUtc17114131 = DateTime.UtcNow
                },
                new User()
                {
                    Id = 3,
                    Username = "Steve",
                    Password = "password",
                    PhoneNumber = "0878504141",
                    LastModifiedUtc17114131 = DateTime.UtcNow
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
                    LastModifiedUtc17114131 = DateTime.UtcNow
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
                    LastModifiedUtc17114131 = DateTime.UtcNow
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
                    LastModifiedUtc17114131 = DateTime.UtcNow
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
                    Passengers = new List<TripPassenger>(),
                    IsActive = true,
                    LastModifiedUtc17114131 = DateTime.UtcNow
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
                    Passengers = new List<TripPassenger>(),
                    IsActive = true,
                    LastModifiedUtc17114131 = DateTime.UtcNow
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
                    Passengers = new List<TripPassenger>(),
                    IsActive = true,
                    LastModifiedUtc17114131 = DateTime.UtcNow
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
                    Passengers = new List<TripPassenger>(),
                    IsActive = true,
                    LastModifiedUtc17114131 = DateTime.UtcNow
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
