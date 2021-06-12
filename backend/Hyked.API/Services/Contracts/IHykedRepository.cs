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

        void AddLog(Audit log);

        bool Save();
    }
}
