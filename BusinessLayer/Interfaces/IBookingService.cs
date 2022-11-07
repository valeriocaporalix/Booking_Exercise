using Booking_Exercise.Models.BookingModels;

namespace Booking_Exercise.BusinessLayer.Interfaces
{
    public interface IBookingService
    {
        public IEnumerable<LightBookingDto> GetAllBookings();
        public DetailsBookingDto GetBookingById(int bookingId);
        public Booking InsertBooking(PostBookingDto postBooking);
        public void AddRoomToBooking(int bookingId, int bookingRoom);
        public void RemoveRoomToBooking(int bookingId, int roomId);
        public void DeleteBooking(int bookingId);
        public Booking UpdateOrCreateBooking(PutBookingDto postBookingDto, int bookingId);
    }
}
