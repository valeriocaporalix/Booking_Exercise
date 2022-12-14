using Booking_Exercise.Models.RoomModels;

namespace Booking_Exercise.BusinessLayer.Interfaces
{
    public interface IRoomService
    {
        public Room Post(PostRoomDto postRoom);
        public DetailRoomDto GetById(int id);
        public IEnumerable<LightRoomDto> GetAll();
    }
}
