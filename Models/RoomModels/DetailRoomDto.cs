using Booking_Exercise.Models.BookingModels;
using Booking_Exercise.Models.HotelModels;
using Booking_Exercise.Models.RoomModels.EnumRoomType;

namespace Booking_Exercise.Models.RoomModels
{
    public class DetailRoomDto
    {
        public int RoomId { get; set; }
        public RoomType RoomCapacity { get; set; }
        public LightHotelDto Hotel { get; set; }
        public ICollection<Booking>? Bookings { get; set; }

    }
}
