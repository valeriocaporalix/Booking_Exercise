using Booking_Exercise.Models.BookingModels;
using Booking_Exercise.Models.HotelModels;
using Booking_Exercise.Models.RoomModels.EnumRoomType;

namespace Booking_Exercise.Models.RoomModels
{
    public class DetailRoomDto
    {
        public int RoomId { get; set; }
        public RoomType RoomCapacity { get; set; }
        public int HotelId { get; set; }
        public LightHotelDto LightHotel { get; set; }
       //public ICollection<Booking>? Bookings { get; set; }

    }
}
