using AutoMapper;
using Hyked.API.Models.Request;
using Hyked.API.Models.Response;
using Hyked.API.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;

namespace Hyked.API.Controllers
{
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ILogger<CarsController> logger;
        private readonly IHykedRepository repository;
        private readonly IMapper mapper;

        public CarsController(ILogger<CarsController> logger, IHykedRepository repository, IMapper mapper)
        {
            this.logger = logger;
            this.repository = repository;
            this.mapper = mapper;
        }

        [HttpGet("/api/user/{userId}/car", Name = "GetUserCar")]
        public IActionResult GetUserCar([Required] int userId)
        {
            if (!this.repository.UserExists(userId))
            {
                this.LogMissingUser(userId);

                return this.NotFound();
            }

            Entities.CarMeta car = this.repository.GetCarForUser(userId);

            if (car == null)
            {
                return this.Problem($"Car does not exist for user {userId}");
            }

            return this.Ok(this.mapper.Map<CarMetaDto>(car));
        }

        [HttpPost("/api/user/{userId}/car")]
        public IActionResult AddCarToUser([Required] int userId, [FromBody] CarMetaRequestDto request)
        {
            if (!this.repository.UserExists(userId))
            {
                this.LogMissingUser(userId);

                return this.NotFound();
            }

            var hasCar = this.repository.GetCarForUser(userId);

            if (hasCar != null)
            {
                return this.Problem($"Car already exists for user {userId}");
            }

            Entities.CarMeta domainCar = this.mapper.Map<Entities.CarMeta>(request);

            this.repository.AddCarForUser(userId, domainCar);

            this.repository.AddLog(new Entities.Audit
            {
                TableName = "Cars",
                Operation = "INSERT"
            });

            this.repository.Save();

            CarMetaDto carToShow = this.mapper.Map<CarMetaDto>(domainCar);

            return this.CreatedAtRoute("GetUserCar", new { userId, id = carToShow.Id }, carToShow);
        }

        [HttpPut("/api/user/{userId}/car")]
        public IActionResult UpdateUserCar([Required] int userId, [FromBody] CarMetaRequestDto request)
        {
            if (!this.repository.UserExists(userId))
            {
                this.LogMissingUser(userId);

                return this.NotFound();
            }

            Entities.CarMeta car = this.repository.GetCarForUser(userId);

            if (car == null)
            {
                return this.NotFound();
            }

            this.mapper.Map(request, car);

            this.repository.AddLog(new Entities.Audit
            {
                TableName = "Cars",
                Operation = "UPDATE"
            });

            this.repository.Save();

            return this.NoContent();
        }

        [HttpDelete("/api/user/{userId}/car")]
        public IActionResult DeleteUserCar([Required] int userId)
        {
            if (!this.repository.UserExists(userId))
            {
                this.LogMissingUser(userId);

                return this.NotFound();
            }

            Entities.CarMeta car = this.repository.GetCarForUser(userId);

            if (car == null)
            {
                return this.NotFound();
            }

            this.repository.DeleteCar(car);

            this.repository.Save();

            return NoContent();
        }

        #region Helpers
        private void LogMissingUser(int userId) => this.logger.LogInformation($"User with id {userId} wasn't found when accessing user-specific trips");
        #endregion
    }
}
