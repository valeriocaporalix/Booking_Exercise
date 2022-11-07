using Booking_Exercise.DataAccessLayer.Interfaces;
using Booking_Exercise.Models.RoomModels;
using Microsoft.EntityFrameworkCore;

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
            return _ctx.Rooms;
        }

        public Room GetById(int id)
        {
            var room = _ctx.Rooms.Include(r => r.HotelId)
                .Include(r => r.Bookings)
                .Single(room => room.RoomId == id);
            return room;
        }

        public Room Post(Room room)
        {
            var roomToAdd = _ctx.Rooms.Add(room).Entity;
            _ctx.SaveChanges();
            return roomToAdd;
        }
    }
}
