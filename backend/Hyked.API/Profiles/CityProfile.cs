using AutoMapper;

namespace Hyked.API.Profiles
{
    public class CityProfile : Profile
    {
        public CityProfile()
        {
            // Mapping from Domain City to CityWithoutPointsOfInterestDto
            CreateMap<Entities.City, Models.CityWithoutPointsOfInterestDto>();
            
            // Mapping from Domain City to CityDto but it has nested prop of points of interest so we need to map these as well
            CreateMap<Entities.City, Models.CityDto>();
            
        }
    }
}
