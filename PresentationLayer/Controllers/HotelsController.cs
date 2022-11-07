using Booking_Exercise.BusinessLayer.Interfaces;
using Booking_Exercise.Models.HotelModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Exercise.PresentationLayer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelService _hotelService;

        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var hotels = _hotelService.GetHotels();
            return Ok(hotels);
        }

        [HttpGet("id")]
        public IActionResult GetDetails(int id)
        {
            try
            {
                var hotel = _hotelService.GetHotelById(id);
                return Ok(hotel);
            }
            catch(InvalidOperationException)
            {
                return NotFound("No hotel with such id");
            }
            
        }

        [HttpPost]
        public IActionResult Post([FromBody] PostHotelDto hotelInput)
        {
            var hotelToAdd = _hotelService.InsertHotel(hotelInput);
            return Created($"{hotelToAdd.HotelId}", hotelToAdd);
        }

        [HttpPut("hotelId")]
        public IActionResult Put([FromBody] PostHotelDto hotelInput, int hotelId)
        {
            try
            {
                var hotelToPost = _hotelService.ModifyOrCreateHotel(hotelInput, hotelId);
                return Created($"{hotelToPost.HotelId}", hotelToPost);
            }
            catch(Exception)
            {
                return NoContent();
            }
        }
    }
}
