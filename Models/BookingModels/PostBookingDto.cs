using Booking_Exercise.Models.RoomModels;
using Booking_Exercise.Models.UserModels;

namespace Booking_Exercise.Models.BookingModels
{
    public class PostBookingDto
    {
        public DateTime StartBooking { get; set; }
        public DateTime EndBooking { get; set; }
        public int UserId { get; set; }
    }
}
