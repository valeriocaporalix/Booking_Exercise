using Booking_Exercise.Models.RoomModels;
using Booking_Exercise.Models.UserModels;

namespace Booking_Exercise.Models.BookingModels
{
    public class DetailsBookingDto
    {
        public int BookingId { get; set; }
        public DateTime StartBooking { get; set; }
        public DateTime EndBooking { get; set; }
        public int UserId { get; set; }
        public LightUserDto User { get; set; }
        public ICollection<LightRoomDto>? Rooms { get; set; }
    }
}
