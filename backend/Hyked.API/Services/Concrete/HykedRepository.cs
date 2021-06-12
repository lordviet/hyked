using Hyked.API.Context;
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

        #region For Deletion
        public IEnumerable<City> GetCities()
        {
            // Important to use ToList to ensure that the query is executed at that specific time
            return this.context.Cities.OrderBy(c => c.Name).ToList();
        }

        public City GetCity(int cityId, bool includePointsOfInterest)
        {
            if (includePointsOfInterest)
            {
                return this.context
                    .Cities
                    .Include(c => c.PointsOfInterest)
                    .Where(c => c.Id == cityId)
                    .FirstOrDefault();
            }

            return this.context
                       .Cities
                       .Where(c => c.Id == cityId)
                       .FirstOrDefault();
        }

        public IEnumerable<PointOfInterest> GetPointOfInterestForCity(int cityId)
        {
            return this.context
                       .PointsOfInterest
                       .Where(p => p.CityId == cityId)
                       .ToList();
        }

        public PointOfInterest GetPointOfInterestForCity(int cityId, int pointOfInterestId)
        {
            return this.context
                       .PointsOfInterest
                       .Where(p => p.CityId == cityId && p.Id == pointOfInterestId)
                       .FirstOrDefault();
        }

        public bool CityExists(int cityId)
        {
            return this.context.Cities.Any(c => c.Id == cityId);
        }

        public void AddPointOfInterestForCity(int cityId, PointOfInterest pointOfInterest)
        {
            // First we fetch the city, then we add to it the new object
            var city = this.GetCity(cityId, false);

            city.PointsOfInterest.Add(pointOfInterest);
        }

        public void UpdatePointOfInterestForCity(int cityId, PointOfInterest pointOfInterest)
        {

        }

        public void DeletePointOfInterest(PointOfInterest pointOfInterest)
        {
            this.context.PointsOfInterest.Remove(pointOfInterest);
        }

        #endregion

        public bool Save()
        {
            // True when the save went well
            return this.context.SaveChanges() >= 0;
        }
    }
}
