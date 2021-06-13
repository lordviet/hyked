using AutoMapper;
using Hyked.API.Entities;
using Hyked.API.Models.Request;
using Hyked.API.Models.Response;
using Hyked.API.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace Hyked.API.Controllers
{
    public class PassengersController : ControllerBase
    {
        private readonly ILogger<PassengersController> logger;
        private readonly IHykedRepository repository;
        private readonly IMapper mapper;

        public PassengersController(ILogger<PassengersController> logger, IHykedRepository repository, IMapper mapper)
        {
            this.logger = logger;
            this.repository = repository;
            this.mapper = mapper;
        }

        [HttpGet("/api/trip/{tripId}/passenger/{username}", Name = "GetPassenger")]
        public IActionResult GetPassenger([Required] int tripId, [Required] string username)
        {
            try
            {
                if (!this.repository.TripExists(tripId))
                {
                    this.LogMissingTrip(tripId);

                    return this.NotFound();
                }

                // TODO check if there is space for user to join 
                TripPassenger passenger = this.repository.GetTripPassenger(tripId, username);

                return this.Ok(this.mapper.Map<TripPassengerDto>(passenger));
            }
            catch (System.Exception ex)
            {
                this.logger.LogCritical(ex.Message);

                return this.NotifyForServerError();

            }
        }

        [HttpPost("/api/trip/{tripId}/passengers")]
        public IActionResult AddTripPassenger([Required] int tripId, [FromBody] TripPassengerRequestDto request)
        {
            if (!this.repository.TripExists(tripId))
            {
                this.LogMissingTrip(tripId);

                return this.NotFound();
            }

            Trip trip = this.repository.GetTrip(tripId);

            if (trip.AvailableSeats == trip.Passengers.Count)
            {
                return this.Problem($"No available seats for trip {tripId}");
            }

            TripPassenger domainTripPassenger = this.mapper.Map<TripPassenger>(request);

            this.repository.AddPassengerForTrip(tripId, domainTripPassenger);

            this.repository.AddLog(new Audit
            {
                TableName = "TripPassengers",
                Operation = "INSERT"
            });

            this.repository.Save();

            TripPassengerDto passengerToShow = this.mapper.Map<TripPassengerDto>(domainTripPassenger);

            return this.CreatedAtRoute("GetPassenger", new { tripId, username = passengerToShow.PassengerUsername }, passengerToShow);
        }

        #region Helpers
        private void LogMissingTrip(int userId) => this.logger.LogInformation($"Trip with id {userId} wasn't found when accessing user-specific trips");

        private ObjectResult NotifyForServerError() => StatusCode(500, "A problem happened while handling your request.");
        #endregion
    }
}
