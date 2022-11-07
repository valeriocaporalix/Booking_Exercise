using Booking_Exercise.Models.BookingModels;
using Booking_Exercise.Models.HotelModels;
using Booking_Exercise.Models.RoomModels.EnumRoomType;

namespace Booking_Exercise.Models.RoomModels
{
    public class Room
    {
        public int RoomId { get; set; }
        public RoomType RoomCapacity { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public ICollection<Booking>? Bookings { get; set; }

    }
}
