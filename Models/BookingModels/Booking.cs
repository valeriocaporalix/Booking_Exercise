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
        public int UserAccountId { get; set; }
        public User UserAccount { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public ICollection<Room> Rooms { get; set; }

    }
}
