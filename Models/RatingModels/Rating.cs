using Booking_Exercise.Models.HotelModels;

namespace Booking_Exercise.Models.RatingModels
{
    public class Rating
    {
        public int RatingId { get; set; }
        public string? Content { get; set; }
        public int RangeRating { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }
}
