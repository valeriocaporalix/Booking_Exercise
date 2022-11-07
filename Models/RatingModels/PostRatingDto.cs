using Booking_Exercise.Models.HotelModels;

namespace Booking_Exercise.Models.RatingModels
{
    public class PostRatingDto
    {
        public string? Content { get; set; }
        public int RangeRating { get; set; }
        public int HotelId { get; set; }
    }
}
