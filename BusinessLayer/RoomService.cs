using AutoMapper;
using Booking_Exercise.BusinessLayer.Interfaces;
using Booking_Exercise.DataAccessLayer.Interfaces;
using Booking_Exercise.Models.RoomModels;

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

        public Room Post(PostRoomDto postRoom)
        {
           var roomToMap= _mapper.Map<Room>(postRoom);
            var roomToAdd = _dataAccessService.Post(roomToMap);
            return roomToAdd;
        }

        public Room GetById(int id)
        {
            var roomToFind = _dataAccessService.GetById(id);  
            return roomToFind;
        }

        public IEnumerable<LightRoomDto> GetAll()
        {
            return _mapper.Map<IEnumerable<LightRoomDto>>(_dataAccessService.GetAll());
        }
    }
}
