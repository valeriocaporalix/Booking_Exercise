using Booking_Exercise.Models.HotelModels;

namespace Booking_Exercise.Models.RatingModels
{
    public class DetailsRatingDto
    {
        public int RatingId { get; set; }
        public string? Content { get; set; }
        public int RangeRating { get; set; }
        public LightHotelDto Hotel { get; set; }
    }
}
