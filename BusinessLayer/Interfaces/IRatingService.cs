using Booking_Exercise.Models.RatingModels;

namespace Booking_Exercise.BusinessLayer.Interfaces
{
    public interface IRatingService
    {
        public IEnumerable<LightRatingDto> GetRatings();
        public Rating InsertRating(PostRatingDto postRating);
        public DetailsRatingDto GetRatingById(int ratingId);
    }
}
