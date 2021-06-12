using AutoMapper;

namespace Hyked.API.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Models.Request.UserRequestDto, Entities.User>();
        }
    }
}
