using AutoMapper;
using Hyked.API.Models;
using Hyked.API.Services.Contracts;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Hyked.API.Controllers
{
    [ApiController]
    [Route("api/cities/{cityId}/pointsofinterest")]
    public class PointsOfInterestController : ControllerBase
    {
        private readonly ILogger<PointsOfInterestController> logger;
        private readonly IHykedRepository cityInfoRepository;
        private readonly IMapper mapper;

        public PointsOfInterestController(ILogger<PointsOfInterestController> logger, IHykedRepository cityInfoRepository, IMapper mapper)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
            this.cityInfoRepository = cityInfoRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetPointsOfInterest(int cityId)
        {
            try
            {
                if (!this.cityInfoRepository.CityExists(cityId))
                {
                    this.logger.LogInformation($"City with id {cityId} wasn't found when accessin points of interest");

                    return this.NotFound();
                }

                var pointsOfInterestForCity = this.cityInfoRepository.GetPointOfInterestForCity(cityId);

                return this.Ok(this.mapper.Map<IEnumerable<PointOfInterestDto>>(pointsOfInterestForCity));
            }
            catch (Exception ex)
            {
                this.logger.LogCritical($"Exception while getting points of interest for city with id {cityId}");
                return StatusCode(500, "A problem happened while handling your request.");
            }
        }

        [HttpGet("{id}", Name = "GetPointOfInterest")]
        public IActionResult GetPointOfInterest(int cityId, int id)
        {
            if (!this.cityInfoRepository.CityExists(cityId))
            {
                return NotFound();
            }

            var pointOfInterest = this.cityInfoRepository.GetPointOfInterestForCity(cityId, id);

            if (pointOfInterest == null)
            {
                return this.NotFound();
            }

            // Map to point of interest Dto from domain model
            return this.Ok(this.mapper.Map<PointOfInterestDto>(pointOfInterest));
        }

        [HttpPost]
        public IActionResult CreatePointOfInterest(int cityId, [FromBody] PointOfInterestForCreationDto pointOfInterest)
        {
            if (pointOfInterest.Description == pointOfInterest.Name)
            {
                ModelState.AddModelError("Description", "The provided description should be different from the name.");
            }

            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            if (!this.cityInfoRepository.CityExists(cityId))
            {
                return this.NotFound();
            }

            Entities.PointOfInterest finalPointOfInterest = this.mapper.Map<Entities.PointOfInterest>(pointOfInterest);

            // Try to add city to the repository            
            this.cityInfoRepository.AddPointOfInterestForCity(cityId, finalPointOfInterest);

            // Try to save to Db 
            bool savedSuccessfully = this.cityInfoRepository.Save();

            if (!savedSuccessfully)
            {
                // Return some error
            }

            // Map to response model and return
            var responsePointOfInterest = this.mapper.Map<PointOfInterestDto>(finalPointOfInterest);

            return CreatedAtRoute("GetPointOfInterest", new { cityId, id = responsePointOfInterest.Id }, responsePointOfInterest);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatePointOfInterest(int cityId, int id, [FromBody] PointOfInterestForCreationDto pointOfInterest)
        {
            if (pointOfInterest.Description == pointOfInterest.Name)
            {
                ModelState.AddModelError("Description", "The provided description should be different from the name.");
            }

            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            if (!this.cityInfoRepository.CityExists(cityId))
            {
                return this.NotFound();
            }

            var pointOfInterestFromEntity = this.cityInfoRepository.GetPointOfInterestForCity(cityId, id);

            if (pointOfInterestFromEntity == null)
            {
                return this.NotFound();
            }

            // This expression will modify the properties in the Entity with the new ones 
            this.mapper.Map(pointOfInterest, pointOfInterestFromEntity);

            // basically this
            //pointOfInterestFromEntity.Name = pointOfInterest.Name;
            //pointOfInterestFromEntity.Description = pointOfInterest.Description;

            
            // Currently does not execute anything
            this.cityInfoRepository.UpdatePointOfInterestForCity(cityId, pointOfInterestFromEntity);

            // Calling save effectively persists changes in the database
            this.cityInfoRepository.Save();

            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult PartialyUpdatePointOfInterest(int cityId, int id, [FromBody] JsonPatchDocument<PointOfInterestForUpdateDto> patchDocument)
        {
            if (!this.cityInfoRepository.CityExists(cityId))
            {
                return this.NotFound();
            }

            Entities.PointOfInterest pointOfInterestEntity = this.cityInfoRepository.GetPointOfInterestForCity(cityId, id);

            if(pointOfInterestEntity == null)
            {
                return this.NotFound();
            }

            PointOfInterestForUpdateDto pointOfInterestToPatch = this.mapper.Map<PointOfInterestForUpdateDto>(pointOfInterestEntity);

            // TODO If anything goes wrong it will be caught by the model state
            patchDocument.ApplyTo(pointOfInterestToPatch);

            if (!ModelState.IsValid)
            {
                return this.BadRequest(ModelState);
            }

            if (pointOfInterestToPatch.Description == pointOfInterestToPatch.Name)
            {
                ModelState.AddModelError("Description", "The provided description should be different from the name.");
            }

            if (!this.TryValidateModel(pointOfInterestToPatch))
            {
                return this.BadRequest(ModelState);
            }

            // This expression will modify the properties in the Entity with the new ones 
            this.mapper.Map(pointOfInterestToPatch, pointOfInterestEntity);
            
            // Currently does not execute anything
            this.cityInfoRepository.UpdatePointOfInterestForCity(cityId, pointOfInterestEntity);

            // Calling save effectively persists changes in the database
            this.cityInfoRepository.Save();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePointOfInterest(int cityId, int id)
        {
            if (!this.cityInfoRepository.CityExists(cityId))
            {
                return this.NotFound();
            }

            Entities.PointOfInterest pointOfInterestEntity = this.cityInfoRepository.GetPointOfInterestForCity(cityId, id);
            
            if (pointOfInterestEntity == null)
            {
                return this.NotFound();
            }

            this.cityInfoRepository.DeletePointOfInterest(pointOfInterestEntity);

            this.cityInfoRepository.Save();

            return NoContent();
        }
    }
}
