using Hyked.API.Entities;
using System.Collections.Generic;

namespace Hyked.API.Services.Contracts
{
    public interface IHykedRepository
    {
        IEnumerable<Trip> GetTrips();

        Trip GetTrip(int tripId);

        IEnumerable<Trip> GetTripsForUser(int userId);

        User GetUserFromTrip(int tripId);

        Trip GetTripForUser(int userId, int tripId);

        IEnumerable<Trip> FindSpecificTrips(string fromLocation, string toLocation);

        User GetUser(int userId);

        User GetUser(string username, string password);

        void RegisterUser(User user);

        bool UserExists(int userId);

        bool UserExists(string username);

        bool TripExists(int tripId);

        IEnumerable<TripPassenger> GetPassengersForTrip(int tripId);

        void AddTripForUser(int userId, Trip trip);

        void DeleteTrip(Trip trip);
        #region Trip Passenger repository actions
        TripPassenger GetTripPassenger(int tripId, string username);

        void AddPassengerForTrip(int tripId, TripPassenger tripPassenger);

        void DeletePassenger(TripPassenger tripPassenger);

        #endregion 

        #region Car repository actions
        CarMeta GetCarForUser(int userId);

        void AddCarForUser(int userId, CarMeta car);

        void DeleteCar(CarMeta car);

        #endregion
        void AddLog(Audit log);

        bool Save();
    }
}
