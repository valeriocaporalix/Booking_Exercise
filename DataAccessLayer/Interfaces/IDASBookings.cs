using Booking_Exercise.Models.BookingModels;

namespace Booking_Exercise.DataAccessLayer.Interfaces
{
    public interface IDASBookings : IDataAccessService<Booking>
    {
        public void AddRooms(int bookingId, int roomId);
        public void DeleteBooking(int bookingId);
    }
}
