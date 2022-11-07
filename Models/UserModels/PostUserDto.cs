namespace Booking_Exercise.Models.UserModels
{
    public class PostUserDto
    {
        public string FullName { get; set; }
        public string FiscalCode { get; set; }
        public string Email { get; set; }
        public string? CreditCard { get; set; }
        public string PhoneNumber { get; set; }
    }
}
