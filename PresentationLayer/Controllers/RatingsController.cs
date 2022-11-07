using Booking_Exercise.BusinessLayer.Interfaces;
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
    }
}
