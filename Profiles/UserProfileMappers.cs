using AutoMapper;
using Booking_Exercise.Models.UserModels;

namespace Booking_Exercise.Profiles
{
    public class UserProfileMappers : Profile
    {
        public UserProfileMappers()
        {
            CreateMap<LightUserDto, User>().ReverseMap();
            CreateMap<PostUserDto, User>().ReverseMap();
        }
    }
}
