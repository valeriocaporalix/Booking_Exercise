using AutoMapper;
using Booking_Exercise.BusinessLayer.Interfaces;
using Booking_Exercise.DataAccessLayer.Interfaces;

namespace Booking_Exercise.BusinessLayer
{
    public class RoomService : IRoomService
    {
        private IDASRooms _dataAccessService;
        private readonly IMapper _mapper;

        public RoomService(IDASRooms dataAccessService, IMapper mapper)
        {
            _dataAccessService = dataAccessService;
            _mapper = mapper;
        }
    }
}
