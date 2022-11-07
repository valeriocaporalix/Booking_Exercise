using Booking_Exercise.Models.HotelModels;
using Booking_Exercise.Models.RoomModels;
using Booking_Exercise.Models.UserModels;

namespace Booking_Exercise.Models.BookingModels
{
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime StartBooking { get; set; }
        public DateTime EndBooking { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public ICollection<Room>? Rooms { get; set; }

    }
}
