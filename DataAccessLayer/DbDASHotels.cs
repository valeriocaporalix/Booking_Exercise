using Booking_Exercise.DataAccessLayer.Interfaces;
using Booking_Exercise.Models.HotelModels;

namespace Booking_Exercise.DataAccessLayer
{
    public class DbDASHotels : IDASHotels
    {
        private readonly BookingDbContext _ctx;

        public DbDASHotels(BookingDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Hotel> GetAll()
        {
            throw new NotImplementedException();
        }

        public Hotel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Hotel Post(Hotel input)
        {
            throw new NotImplementedException();
        }
    }
}
