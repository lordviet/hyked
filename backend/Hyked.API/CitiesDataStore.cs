using Hyked.API.Models;
using System.Collections.Generic;

namespace Hyked.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            this.Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one where Spidey swings",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Central Park",
                            Description = "The most famous park"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Empire State Building",
                            Description = "The one where the emperor lives"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "California",
                    Description = "The one with the billionaires",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 3,
                            Name = "Hollywood sign",
                            Description = "The most famous sign"
                        },
                        new PointOfInterestDto()
                        {
                            Id = 4,
                            Name = "Mountain view",
                            Description = "The one with the programmers"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 3,
                    Name = "Georgia",
                    Description = "The one with the online university",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 5,
                            Name = "Georgia Tech",
                            Description = "That one university with the online program"
                        }
                    }
                },
            };
        }
    }
}
