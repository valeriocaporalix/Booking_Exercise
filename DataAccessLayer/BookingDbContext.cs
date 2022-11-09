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

        // Mediante il builder, andiamo a creare gli oggetti all'interno della tabella hotel
        // essendo nel context ed usando l'OnModelCreating, andiamo ad agire direttamente
        // nel database.

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Hotel>().HasData(
                    new Hotel { HotelId= 11, Name = "Hotel TestOne", Address = "Via Test 10" },
                    new Hotel { HotelId = 12, Name = "Hotel TestTwo", Address = "Via Test 10" },
                    new Hotel { HotelId = 13, Name = "Hotel TestThree", Address = "Via Test 10" },
                    new Hotel { HotelId = 14, Name = "Hotel TestFour", Address = "Via Test 10" },
                    new Hotel { HotelId = 15, Name = "Hotel TestFive", Address = "Via Test 10" },
                    new Hotel { HotelId = 16, Name = "Hotel TestSix", Address = "Via Test 10" },
                    new Hotel { HotelId = 17, Name = "Hotel TestSeven", Address = "Via Test 10" },
                    new Hotel { HotelId = 18, Name = "Hotel TestEight", Address = "Via Test 10" },
                    new Hotel { HotelId = 19, Name = "Hotel TestNine", Address = "Via Test 10" },
                    new Hotel { HotelId = 20, Name = "Hotel TestTen", Address = "Via Test 10" }
                );
        }

        // Una volta definito il metodo, dobbiamo modificare la nostra migrazione:
        // add-migration Seeding
        // update-database
    }
}
