using Booking_Exercise.Models.BookingModels;
using Booking_Exercise.Models.HotelModels;
using Booking_Exercise.Models.RatingModels;
using Booking_Exercise.Models.RoomModels;
using Booking_Exercise.Models.UserModels;
using Microsoft.EntityFrameworkCore;

namespace Booking_Exercise.DataAccessLayer
{
    public class BookingDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Room> Rooms { get; set; }

        public BookingDbContext(DbContextOptions<BookingDbContext> options) 
            : base(options)
        {

        }
    }
}
