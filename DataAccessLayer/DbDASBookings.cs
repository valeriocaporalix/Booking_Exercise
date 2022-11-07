using Booking_Exercise.DataAccessLayer.Interfaces;
using Booking_Exercise.Models.BookingModels;
using Microsoft.EntityFrameworkCore;

namespace Booking_Exercise.DataAccessLayer
{
    public class DbDASBookings : IDASBookings
    {
        private readonly BookingDbContext _ctx;

        public DbDASBookings(BookingDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Booking> GetAll()
        {
            return _ctx.Bookings;
        }

        public Booking GetById(int id)
        {
            var bookingFound = _ctx.Bookings.Include(booking => booking.User)
                                            .Include(booking => booking.Rooms)
                                            .Single(booking => booking.BookingId == id);
            return bookingFound;
        }

        public Booking Post(Booking input)
        {
            var bookingToAdd = _ctx.Bookings.Add(input).Entity;
            _ctx.SaveChanges();
            return bookingToAdd;
        }

        public void AddRooms(int bookingId, int roomId)
        {
            var bookingToUpdate = _ctx.Bookings.Include(booking => booking.Rooms)
                                               .Single(booking => booking.BookingId == bookingId);
            var roomToInsert = _ctx.Rooms.Single(room => room.RoomId == roomId);
            bookingToUpdate.Rooms.Add(roomToInsert);
            _ctx.SaveChanges();
        }

        public void RemoveRoom(int bookingId, int roomId)
        {
            var bookingToUpdate = _ctx.Bookings.Include(booking => booking.Rooms)
                                   .Single(booking => booking.BookingId == bookingId);
            var roomToRemove = _ctx.Rooms.Single(room => room.RoomId == roomId);
            bookingToUpdate.Rooms.Remove(roomToRemove);
            _ctx.SaveChanges();
        }

        public void DeleteBooking(int bookingId)
        {
            var bookingToDelete = _ctx.Bookings.Single(booking => booking.BookingId == bookingId);
            _ctx.Bookings.Remove(bookingToDelete);
            _ctx.SaveChanges();
        }

        public Booking UpdateBooking(Booking postBooking)
        {
            var bookingToUpdate = _ctx.Bookings.Single(booking => booking.BookingId == postBooking.BookingId);
            bookingToUpdate.BookingId = postBooking.BookingId;
            bookingToUpdate.StartBooking = postBooking.StartBooking;
            bookingToUpdate.EndBooking = postBooking.EndBooking;
            _ctx.SaveChanges();
            return bookingToUpdate;
        }
    }
}
