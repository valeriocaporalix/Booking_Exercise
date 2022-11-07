using Booking_Exercise.Models.BookingModels;

namespace Booking_Exercise.Models.UserModels
{
    public class User
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string FiscalCode { get; set; }
        public string Email { get; set; }
        public string? CreditCard { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Booking>? Bookings { get; set; }
    }
}
