using Booking_Exercise.DataAccessLayer.Interfaces;
using Booking_Exercise.Models.QueryParameters;
using Booking_Exercise.Models.RatingModels;
using Microsoft.AspNetCore.Server.Kestrel.Core.Features;
using Microsoft.EntityFrameworkCore;

namespace Booking_Exercise.DataAccessLayer
{
    public class DbDASRatings : IDASRatings
    {
        private readonly BookingDbContext _ctx;

        public DbDASRatings(BookingDbContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Rating> GetAll()
        {
            return _ctx.Ratings;
        }

        public IEnumerable<Rating> GetAllPaging(PageParameters parameters)
        {
            return _ctx.Ratings.Skip((parameters.PageNumber - 1) * parameters.PageSize)
                               .Take(parameters.PageSize);
        }

        public Rating GetById(int id)
        {
            var rating = _ctx.Ratings.Include(rate => rate.Hotel)
                                     .Single(rate => rate.RatingId == id);
            return rating;
        }

        public Rating Post(Rating input)
        {
            var rating = _ctx.Ratings.Add(input);
            _ctx.SaveChanges();
            return rating.Entity;
        }
    }
}
