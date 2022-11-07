using AutoMapper;
using Booking_Exercise.Models.RatingModels;

namespace Booking_Exercise.Profiles
{
    public class RatingProfileMappers : Profile
    {
        public RatingProfileMappers()
        {
            CreateMap<Rating, LightRatingDto>();
            CreateMap<PostRatingDto, Rating>();
            CreateMap<Rating, DetailsRatingDto>();
        }
    }
}
