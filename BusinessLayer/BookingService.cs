using AutoMapper;
using Booking_Exercise.BusinessLayer.Interfaces;
using Booking_Exercise.DataAccessLayer.Interfaces;

namespace Booking_Exercise.BusinessLayer
{
    public class BookingService : IBookingService
    {
        private IDASBookings _dataAccessService;
        private readonly IMapper _mapper;

        public BookingService(IDASBookings dataAccessService, IMapper mapper)
        {
            _dataAccessService = dataAccessService;
            _mapper = mapper;
        }

    }
}
