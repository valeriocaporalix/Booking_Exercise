using AutoMapper;
using Booking_Exercise.Models.RoomModels;

namespace Booking_Exercise.Profiles
{
    public class RoomProfileMappers : Profile
    {
        public RoomProfileMappers()
        {
            CreateMap<LightRoomDto, Room>().ReverseMap();
            CreateMap<PostRoomDto, Room>().ReverseMap();
            CreateMap<DetailRoomDto, Room>().ReverseMap();
            CreateMap<LightRoomInHotelDto, Room>().ReverseMap();
        }
    }
}
