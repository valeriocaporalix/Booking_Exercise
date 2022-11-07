using Booking_Exercise.DataAccessLayer.Interfaces;
using Booking_Exercise.Models.BookingModels;

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
            throw new NotImplementedException();
        }

        public Booking GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Booking Post(Booking input)
        {
            throw new NotImplementedException();
        }
    }
}
