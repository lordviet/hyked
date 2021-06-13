using AutoMapper;
using Hyked.API.Models.Request;
using Hyked.API.Models.Response;
using Hyked.API.Services.Contracts;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hyked.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : ControllerBase
    {
        private readonly ILogger<TripsController> logger;
        private readonly IHykedRepository repository;
        private readonly IMapper mapper;

        public TripsController(ILogger<TripsController> logger, IHykedRepository repository, IMapper mapper)
        {
            this.logger = logger;
            this.repository = repository;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetTrips()
        {
            try
            {
                var trips = this.repository.GetTrips();

                return this.Ok(this.mapper.Map<IEnumerable<TripDto>>(trips));
            }
            catch (System.Exception ex)
            {
                this.logger.LogCritical(ex.Message);

                return this.NotifyForServerError();
            }
        }

        [HttpGet("specific")]
        public IActionResult FindSpecificTrips([Required] string fromLocation, [Required] string toLocation)
        {
            var trips = this.repository.FindSpecificTrips(fromLocation, toLocation);

            return this.Ok(this.mapper.Map<IEnumerable<TripDto>>(trips));
        }

        [HttpGet("/api/user/{userId}/trips")]
        public IActionResult GetUserTrips([Required] int userId)
        {
            try
            {
                if (!this.repository.UserExists(userId))
                {
                    this.LogMissingUser(userId);

                    return this.NotFound();
                }

                var trips = this.repository.GetTripsForUser(userId);

                return this.Ok(this.mapper.Map<IEnumerable<TripDto>>(trips));
            }
            catch (System.Exception ex)
            {
                this.logger.LogCritical(ex.Message);

                return this.NotifyForServerError();

            }
        }

        [HttpGet("/api/user/{userId}/trip/{id}", Name = "GetUserTrip")]
        public IActionResult GetUserTrip([Required] int userId, int id)
        {
            try
            {
                if (!this.repository.UserExists(userId))
                {
                    this.LogMissingUser(userId);

                    return this.NotFound();
                }

                var trip = this.repository.GetTripForUser(userId, id);

                return this.Ok(this.mapper.Map<TripDto>(trip));
            }
            catch (System.Exception ex)
            {
                this.logger.LogCritical(ex.Message);

                return this.NotifyForServerError();

            }
        }

        [HttpGet("/api/trip/{tripId}/driver")]
        public IActionResult GetUserFromTrip([Required] int tripId)
        {
            if (!this.repository.TripExists(tripId))
            {
                return this.NotFound();
            }

            Entities.User user = this.repository.GetUserFromTrip(tripId);

            CarMetaDto mappedCar = this.mapper.Map<CarMetaDto>(user.Car);

            DriverDto driver = new DriverDto
            {
                Id = user.Id,
                Username = user.Username,
                PhoneNumber = user.PhoneNumber,
                Car = mappedCar,
            };

            return this.Ok(driver);
        }

        [HttpPost("/api/user/{userId}/trips")]
        public IActionResult AddTrip([Required] int userId, [FromBody] TripRequestDto request)
        {
            if (!this.repository.UserExists(userId))
            {
                this.LogMissingUser(userId);

                return this.NotFound();
            }

            Entities.Trip domainTrip = this.mapper.Map<Entities.Trip>(request);

            this.repository.AddTripForUser(userId, domainTrip);

            this.repository.AddLog(new Entities.Audit
            {
                TableName = "Trips",
                Operation = "INSERT"
            });

            this.repository.Save();

            TripDto tripToShow = this.mapper.Map<TripDto>(domainTrip);

            return this.CreatedAtRoute("GetUserTrip", new { userId, id = tripToShow.Id }, tripToShow);
        }

        [HttpPut("/api/user/{userId}/trip/{id}")]
        public IActionResult UpdateUserTrip([Required] int userId, [Required] int id, [FromBody] TripRequestDto request)
        {
            if (!this.repository.UserExists(userId))
            {
                this.LogMissingUser(userId);

                return this.NotFound();
            }

            Entities.Trip trip = this.repository.GetTripForUser(userId, id);

            if (trip == null)
            {
                return this.NotFound();
            }

            this.mapper.Map(request, trip);

            this.repository.AddLog(new Entities.Audit
            {
                TableName = "Trips",
                Operation = "UPDATE"
            });

            this.repository.Save();

            return this.NoContent();
        }

        [HttpPatch("/api/user/{userId}/trip/{id}")]
        public IActionResult PartialyUpdateUserTrip([Required] int userId, [Required] int id, [FromBody] JsonPatchDocument<TripRequestDto> patchDocument)
        {
            if (!this.repository.UserExists(userId))
            {
                this.LogMissingUser(userId);

                return this.NotFound();
            }

            Entities.Trip trip = this.repository.GetTripForUser(userId, id);

            if (trip == null)
            {
                return this.NotFound();
            }

            var tripToPatch = this.mapper.Map<TripRequestDto>(patchDocument);

            // TODO If anything goes wrong it will be caught by the model state
            patchDocument.ApplyTo(tripToPatch);

            // This expression will modify the properties in the Entity with the new ones 
            this.mapper.Map(tripToPatch, trip);

            this.repository.AddLog(new Entities.Audit
            {
                TableName = "Trips",
                Operation = "UPDATE"
            });

            // Calling save effectively persists changes in the database
            this.repository.Save();

            return NoContent();
        }

        [HttpDelete("/api/user/{userId}/trip/{id}")]
        public IActionResult DeleteTrip([Required] int userId, [Required] int id)
        {
            if (!this.repository.UserExists(userId))
            {
                this.LogMissingUser(userId);

                return this.NotFound();
            }

            Entities.Trip trip = this.repository.GetTripForUser(userId, id);

            if (trip == null)
            {
                return this.NotFound();
            }

            this.repository.DeleteTrip(trip);

            this.repository.Save();

            return NoContent();
        }

        #region Helpers
        private void LogMissingUser(int userId) => this.logger.LogInformation($"User with id {userId} wasn't found when accessing user-specific trips");

        private ObjectResult NotifyForServerError() => StatusCode(500, "A problem happened while handling your request.");
        #endregion
    }
}
