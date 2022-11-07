using AutoMapper;
using Booking_Exercise.BusinessLayer.Interfaces;
using Booking_Exercise.DataAccessLayer.Interfaces;

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
    }
}
