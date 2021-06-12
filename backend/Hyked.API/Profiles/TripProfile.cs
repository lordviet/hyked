using AutoMapper;

namespace Hyked.API.Profiles
{
    public class TripProfile : Profile
    {
        public TripProfile()
        {
            CreateMap<Entities.Trip, Models.Response.TripDto>();

            CreateMap<Models.Request.TripRequestDto, Entities.Trip>().ReverseMap();            
        }
    }
}
