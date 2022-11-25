using AutoMapper;
using Booking_Exercise.BusinessLayer.Interfaces;
using Booking_Exercise.DataAccessLayer.Interfaces;
using Booking_Exercise.Models.HotelModels;
using Booking_Exercise.Models.QueryParameters;
using Booking_Exercise.Models.RatingModels;

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

        public IEnumerable<LightRatingDto> GetRatings(PageParameters parameters)
        {
            var ratingList = _dataAccessService.GetAllPaging(parameters);
            var mappedRating = _mapper.Map<List<LightRatingDto>>(ratingList);
            return mappedRating;
        }

        public DetailsRatingDto GetRatingById(int ratingId)
        {
            var ratingFoundById = _dataAccessService.GetById(ratingId);
            var mappedRating = _mapper.Map<DetailsRatingDto>(ratingFoundById);
            return mappedRating;
        }

        public Rating InsertRating(PostRatingDto postRating)
        {
            var mappedRating = _mapper.Map<Rating>(postRating);
            if(postRating.RangeRating > 5 || postRating.RangeRating <= 0)
            {
                throw new ArgumentException();
            }
            return _dataAccessService.Post(mappedRating);
        }
    }
}
