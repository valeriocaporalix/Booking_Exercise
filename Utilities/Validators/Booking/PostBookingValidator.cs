using Booking_Exercise.Models.BookingModels;
using FluentValidation;

namespace Booking_Exercise.Utilities.Validators.Booking
{
    public class PostBookingValidator : AbstractValidator<PostBookingDto>
    {
        public PostBookingValidator()
        {
            RuleFor(booking => booking.StartBooking).LessThan(booking => booking.EndBooking);
            RuleFor(booking => booking.UserId).NotEmpty();
        }
    }
}
