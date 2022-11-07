using Booking_Exercise.DataAccessLayer.Interfaces;
using Booking_Exercise.Models.UserModels;

namespace Booking_Exercise.DataAccessLayer
{
    public class DbDASUsers : IDASUsers
    {
        private readonly BookingDbContext _ctx;

        public DbDASUsers(BookingDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public User Post(User input)
        {
            throw new NotImplementedException();
        }
    }
}
