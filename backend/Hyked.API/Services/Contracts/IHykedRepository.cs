using Hyked.API.Entities;
using System.Collections.Generic;

namespace Hyked.API.Services.Contracts
{
    public interface IHykedRepository
    {                
        IEnumerable<Trip> GetTrips();

        Trip GetTrip(int tripId);

        IEnumerable<Trip> GetTripsForUser(int userId);

        Trip GetTripForUser(int userId, int tripId);

        IEnumerable<Trip> FindSpecificTrips(string fromLocation, string toLocation);

        User GetUser(int userId);

        User GetUser(string username, string password);

        void RegisterUser(User user);

        bool UserExists(int userId);

        void AddTripForUser(int userId, Trip trip);

        //void EditTripForUser(int userId, Trip trip);

        void DeleteTrip(Trip trip);

        CarMeta GetCarForUser(int userId);

        void AddCarForUser(int userId, CarMeta car);

        void DeleteCar(CarMeta car);
        // Edit car for user potentially

        void AddLog(Audit log);
        #region For Deletion
        IEnumerable<City> GetCities();

        City GetCity(int cityId, bool includePointsOfInterest);

        IEnumerable<PointOfInterest> GetPointOfInterestForCity(int cityId);

        PointOfInterest GetPointOfInterestForCity(int cityId, int pointOfInterestId);

        bool CityExists(int cityId);

        void AddPointOfInterestForCity(int cityId, PointOfInterest pointOfInterest);

        void UpdatePointOfInterestForCity(int cityId, PointOfInterest pointOfInterest);

        void DeletePointOfInterest(PointOfInterest pointOfInterest);
        #endregion

        bool Save();
    }
}
