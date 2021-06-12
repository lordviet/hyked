using AutoMapper;

namespace Hyked.API.Profiles
{
    public class CarsProfile : Profile
    {
        public CarsProfile()
        {
            CreateMap<Entities.CarMeta, Models.Response.CarMetaDto>();

            CreateMap<Models.Request.CarMetaRequestDto, Entities.CarMeta>().ReverseMap();
        }
    }
}
