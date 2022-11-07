using AutoMapper;
using Booking_Exercise.Models.HotelModels;

namespace Booking_Exercise.Profiles
{
    public class HotelProfileMappers : Profile
    {
        public HotelProfileMappers()
        {
            CreateMap<Hotel, LightHotelDto>();
            CreateMap<PostHotelDto, Hotel>();
        }
    }
}
