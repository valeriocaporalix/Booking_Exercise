using AutoMapper;
using Booking_Exercise.BusinessLayer.Interfaces;
using Booking_Exercise.DataAccessLayer.Interfaces;

namespace Booking_Exercise.BusinessLayer
{
    public class RatingService : IRatingService
    {
        private IDASRatings _dataAccessService;
        private readonly IMapper _mapper;

        public RatingService(IDASRatings dataAccessService, IMapper mapper)
        {
            _dataAccessService = dataAccessService;
            _mapper = mapper;
        }
    }
}
