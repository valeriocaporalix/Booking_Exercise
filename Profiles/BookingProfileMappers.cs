using AutoMapper;
using Booking_Exercise.Models.BookingModels;

namespace Booking_Exercise.Profiles
{
    public class BookingProfileMappers : Profile
    {
        public BookingProfileMappers()
        {
            CreateMap<DetailsBookingDto, Booking>().ReverseMap();
            CreateMap<LightBookingDto, Booking>().ReverseMap();
            CreateMap<PostBookingDto, Booking>().ReverseMap();

        }
    }
}
