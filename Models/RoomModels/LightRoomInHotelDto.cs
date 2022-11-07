using Booking_Exercise.Models.RoomModels.EnumRoomType;

namespace Booking_Exercise.Models.RoomModels
{
    public class LightRoomInHotelDto
    {
        public int RoomId { get; set; }
        public RoomType RoomCapacity { get; set; }
    }
}
