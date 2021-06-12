﻿using Hyked.API.Context;
using Hyked.API.Entities;
using Hyked.API.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Hyked.API.Services.Concrete
{
    public class HykedRepository : IHykedRepository
    {
        private HykedContext context;

        public HykedRepository(HykedContext context)
        {
            this.context = context;
        }

        public IEnumerable<Trip> GetTrips()
        {
            return this.context
                       .Trips
                       .OrderBy(t => t.DepartureTimeUtc)
                       .ToList();
        }

        public Trip GetTrip(int tripId)
        {
            // include User? 
            return this.context
                       .Trips
                       .Where(t => t.Id == tripId)
                       .FirstOrDefault();
        }

        public IEnumerable<Trip> GetTripsForUser(int userId)
        {
            return this.context
                       .Trips
                       .Where(t => t.UserId == userId)
                       .ToList();
        }

        public Trip GetTripForUser(int userId, int tripId)
        {
            return this.context
                       .Trips
                       .Where(t => t.UserId == userId && t.Id == tripId)
                       .FirstOrDefault();
        }

        public IEnumerable<Trip> FindSpecificTrips(string fromLocation, string toLocation)
        {
            return this.context
                       .Trips
                       .Where(t => t.FromLocation == fromLocation && t.ToLocation == toLocation)
                       .ToList();
        }

        public User GetUser(int userId)
        {
            return this.context
                       .Users
                       .Where(u => u.Id == userId)
                       .FirstOrDefault();
        }

        public User GetUser(string username, string password)
        {
            return this.context
                       .Users
                       .Where(u => u.Username == username && u.Password == password)
                       .FirstOrDefault();
        }

        public void RegisterUser(User user)
        {
            this.context.Users.Add(user);
        }

        public bool UserExists(int userId)
        {
            return this.context.Users.Any(u => u.Id == userId);
        }

        public bool TripExists(int tripId)
        {
            return this.context.Trips.Any(t => t.Id == tripId);
        }

        public CarMeta GetCarForUser(int userId)
        {
            return this.context
                       .Cars
                       .Where(c => c.UserId == userId)
                       .FirstOrDefault();
        }

        public void AddTripForUser(int userId, Trip trip)
        {
            var user = this.GetUser(userId);

            user.Trips.Add(trip);
        }

        //public void EditTripForUser(int userId, Trip trip)
        //{
        //    throw new System.NotImplementedException();
        //}

        public void DeleteTrip(Trip trip)
        {
            this.context.Trips.Remove(trip);
        }

        public void AddCarForUser(int userId, CarMeta car)
        {
            var user = this.GetUser(userId);

            user.Car = car;
        }

        public void DeleteCar(CarMeta car)
        {
            this.context.Cars.Remove(car);
        }

        public void AddLog(Audit audit)
        {
            this.context.log_17114131.Add(audit);
        }

        public bool Save()
        {
            // True when the save went well
            return this.context.SaveChanges() >= 0;
        }
    }
}