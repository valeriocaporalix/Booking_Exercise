namespace Booking_Exercise.Models.BookingModels
{
    public class LightBookingDto
    {
        public int BookingId { get; set; }
        public DateTime StartBooking { get; set; }
        public DateTime EndBooking { get; set; }
        public int UserId { get; set; }
    }
}
