using AutoMapper;
using Booking_Exercise.BusinessLayer.Interfaces;
using Booking_Exercise.DataAccessLayer.Interfaces;
using Booking_Exercise.Models.BookingModels;

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

        public IEnumerable<LightBookingDto> GetAllBookings()
        {
            var bookings = _dataAccessService.GetAll();
            var mappedBookings = _mapper.Map<List<LightBookingDto>>(bookings);
            return mappedBookings;
        }

        public DetailsBookingDto GetBookingById(int bookingId)
        {
            var bookingFoundById = _dataAccessService.GetById(bookingId);
            var mappedBooking = _mapper.Map<DetailsBookingDto>(bookingFoundById);
            return mappedBooking;
        }

        public Booking InsertBooking(PostBookingDto postBooking)
        {
            var mappedBooking = _mapper.Map<Booking>(postBooking);
            var bookingToAdd = _dataAccessService.Post(mappedBooking);
            return bookingToAdd;
        }
        public void AddRoomToBooking(int bookingId, int roomId)
        {
            _dataAccessService.AddRooms(bookingId, roomId);
        }
        public void DeleteBooking(int bookingId)
        {
            _dataAccessService.DeleteBooking(bookingId);
        }
    }
}
