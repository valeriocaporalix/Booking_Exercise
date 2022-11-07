using Booking_Exercise.Models.RoomModels.EnumRoomType;

namespace Booking_Exercise.Models.RoomModels
{
    public class LightRoomDto
    {
        public int RoomId { get; set; }
        public RoomType RoomCapacity { get; set; }
        public int HotelId { get; set; }
    }
}
