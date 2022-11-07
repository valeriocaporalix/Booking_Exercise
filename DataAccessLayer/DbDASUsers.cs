using Booking_Exercise.DataAccessLayer.Interfaces;
using Booking_Exercise.Models.UserModels;
using Microsoft.EntityFrameworkCore;

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
            return _ctx.Users;
        }

        public User GetById(int id)
        {
            var user = _ctx.Users.Include(u => u.Bookings)
                .Single(u => u.UserId == id);
            return user;
        }

        public User Post(User user)
        {
            var userToAdd = _ctx.Add(user).Entity;
            _ctx.SaveChanges();
            return userToAdd;
        }
    }
}
