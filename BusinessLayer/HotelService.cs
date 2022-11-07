using AutoMapper;
using Booking_Exercise.BusinessLayer.Interfaces;
using Booking_Exercise.DataAccessLayer.Interfaces;

namespace Booking_Exercise.BusinessLayer
{
    public class HotelService : IHotelService
    {
        private IDASHotels _dataAccessService;
        private readonly IMapper _mapper;

        public HotelService(IDASHotels dataAccessService, IMapper mapper)
        {
            _dataAccessService = dataAccessService;
            _mapper = mapper;
        }
    }
}
