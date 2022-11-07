using Booking_Exercise.DataAccessLayer.Interfaces;
using Booking_Exercise.Models.RoomModels;

namespace Booking_Exercise.DataAccessLayer
{
    public class DbDASRooms : IDASRooms
    {
        private readonly BookingDbContext _ctx;

        public DbDASRooms(BookingDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Room> GetAll()
        {
            throw new NotImplementedException();
        }

        public Room GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Room Post(Room input)
        {
            throw new NotImplementedException();
        }
    }
}
