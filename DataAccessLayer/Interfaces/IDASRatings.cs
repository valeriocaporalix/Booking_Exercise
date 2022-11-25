using Booking_Exercise.Models.QueryParameters;
using Booking_Exercise.Models.RatingModels;

namespace Booking_Exercise.DataAccessLayer.Interfaces
{
    public interface IDASRatings : IDataAccessService<Rating>
    {
        public IEnumerable<Rating> GetAllPaging(PageParameters parameters);
    }
}
