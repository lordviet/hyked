using AutoMapper;

namespace Hyked.API.Profiles
{
    public class TripPassengerProfile : Profile
    {
        public TripPassengerProfile()
        {
            CreateMap<Entities.TripPassenger, Models.Response.TripPassengerDto>();

            // TODO maybe I don't need this mapper at all            
            CreateMap<Models.Request.TripPassengerRequestDto, Entities.TripPassenger>().ReverseMap();
        }
    }
}
