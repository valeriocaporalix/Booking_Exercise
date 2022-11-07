using Booking_Exercise.DataAccessLayer.Interfaces;
using Booking_Exercise.Models.HotelModels;
using Microsoft.EntityFrameworkCore;

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
            var hotels = _ctx.Hotels;
            return hotels;
        }

        public Hotel GetById(int id)
        {
            var hotel = _ctx.Hotels.Include(hotel => hotel.Ratings)
                                   .Include(hotel => hotel.Rooms)
                                   .Single(hotel => hotel.HotelId == id);
            return hotel;
        }

        public Hotel Post(Hotel input)
        {
            var hotel = _ctx.Hotels.Add(input);
            _ctx.SaveChanges();
            return hotel.Entity;
        }

        public Hotel Put(Hotel input, int hotelId)
        {
            var hotelToUpdate = _ctx.Hotels.Single(hotel => hotel.HotelId == hotelId);
            hotelToUpdate.HotelId = hotelId;
            hotelToUpdate.Name = input.Name;
            hotelToUpdate.Address = input.Address;
            _ctx.Hotels.Update(hotelToUpdate);
            _ctx.SaveChanges();
            return hotelToUpdate;
        }
    }
}
