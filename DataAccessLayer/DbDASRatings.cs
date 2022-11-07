using Booking_Exercise.DataAccessLayer.Interfaces;
using Booking_Exercise.Models.RatingModels;

namespace Booking_Exercise.DataAccessLayer
{
    public class DbDASRatings : IDASRatings
    {
        private readonly BookingDbContext _ctx;

        public DbDASRatings(BookingDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Rating> GetAll()
        {
            throw new NotImplementedException();
        }

        public Rating GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Rating Post(Rating input)
        {
            throw new NotImplementedException();
        }
    }
}
