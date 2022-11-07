using Booking_Exercise.Models.RatingModels;
using Booking_Exercise.Models.RoomModels;

namespace Booking_Exercise.Models.HotelModels
{
    public class DetailsHotelDto
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<LightRatingDto> Ratings { get; set; }
        public ICollection<LightRoomInHotelDto> Rooms { get; set; }
    }
}
