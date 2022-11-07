using Booking_Exercise.Models.BookingModels;
using Booking_Exercise.Models.RatingModels;
using Booking_Exercise.Models.RoomModels;

namespace Booking_Exercise.Models.HotelModels
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<Rating> Ratings { get; set; } 
        public ICollection<Room> Rooms { get; set; }
    }
}
