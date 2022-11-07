using Booking_Exercise.Models.RoomModels.EnumRoomType;

namespace Booking_Exercise.Models.RoomModels
{
    public class PostRoomDto
    {
        public RoomType RoomCapacity { get; set; }
        public int HotelId { get; set; }
    }
}
