using Booking_Exercise.Models.HotelModels;

namespace Booking_Exercise.DataAccessLayer.Interfaces
{
    public interface IDASHotels : IDataAccessService<Hotel>
    {
        public Hotel Put(Hotel input, int hotelId);
    }
}
