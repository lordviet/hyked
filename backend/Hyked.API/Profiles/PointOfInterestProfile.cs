using AutoMapper;

namespace Hyked.API.Profiles
{
    public class PointOfInterestProfile : Profile
    {
        public PointOfInterestProfile()
        {
            // From domain model to response model
            CreateMap<Entities.PointOfInterest, Models.PointOfInterestDto>();

            // From request model to domain model
            CreateMap<Models.PointOfInterestForCreationDto, Entities.PointOfInterest>();

            // From request update model to domain model 
            CreateMap<Models.PointOfInterestForUpdateDto, Entities.PointOfInterest>().ReverseMap(); // ReverseMap creates both mapping operations
        }
    }
}
