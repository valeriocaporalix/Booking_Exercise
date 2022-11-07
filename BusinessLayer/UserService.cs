using AutoMapper;
using Booking_Exercise.BusinessLayer.Interfaces;
using Booking_Exercise.DataAccessLayer.Interfaces;
using Booking_Exercise.Models.UserModels;

namespace Booking_Exercise.BusinessLayer
{
    public class UserService : IUserService
    {
        private IDASUsers _dataAccessService;
        private readonly IMapper _mapper;

        public UserService(IDASUsers dataAccessService, IMapper mapper)
        {
            _dataAccessService = dataAccessService;
            _mapper = mapper;
        }

        public User Post(PostUserDto postUserDto)
        {
            var userToAdd = _mapper.Map<User>(postUserDto);
            _dataAccessService.Post(userToAdd);
            return userToAdd;
        }

        public IEnumerable<LightUserDto> GetAll()
        {
            var userToMap = _mapper.Map<IEnumerable<LightUserDto>>(_dataAccessService.GetAll());
            return userToMap;
        }

        public DetailUserDto GetById(int id)
        {
            var userToFind = _dataAccessService.GetById(id);
            var mappedUser = _mapper.Map<DetailUserDto>(userToFind);
            return mappedUser;
        }
    }
}
