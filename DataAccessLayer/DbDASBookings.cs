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
    }
}
