using Booking_Exercise.BusinessLayer.Interfaces;
using Booking_Exercise.Models.RatingModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Exercise.PresentationLayer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        private IRatingService _ratingService;

        public RatingsController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var ratingList = _ratingService.GetRatings();
            return Ok(ratingList);
        }

        [HttpGet("{ratingId}")]
        public IActionResult GetDetails(int ratingId)
        {
            try
            {
                var ratingFoundById = _ratingService.GetRatingById(ratingId);
                return Ok(ratingFoundById);
            }
            catch(InvalidOperationException)
            {
                return NotFound("No rating with such id");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] PostRatingDto postRating)
        {
            try
            {
                var ratingToAdd = _ratingService.InsertRating(postRating);
                return Created($"{ratingToAdd.RatingId}", ratingToAdd);
            }
            catch(ArgumentException)
            {
                return BadRequest("Rating range between 1 to 5");
            }
        }
    }
}
