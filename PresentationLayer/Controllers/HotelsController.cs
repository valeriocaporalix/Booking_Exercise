using Booking_Exercise.BusinessLayer.Interfaces;
using Booking_Exercise.Models.HotelModels;
using Booking_Exercise.Models.QueryParameters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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

        // Aggiugiamo un FromQuery.
        public IActionResult GetAll([FromQuery] PageParameters parameters)
        {
            // Dichiaro una variabile hotels e la inizializzo tramite il metodo GetHotels del service
            // che ci restituisce una PagedList con la lista di hotel e una RawData
            var hotels = _hotelService.GetHotels(parameters);

            // Istanziamo un oggetto anonimo (metadata) da inserire nell'headers.
            var metadata = new
            {
                hotels.TotalCount,
                hotels.PageSize,
                hotels.CurrentPage,
                hotels.TotalPages,
                hotels.HasNext,
                hotels.HasPrevious
            };
            // Serializziamo ed inseriamo il metadata nell'headers.
            Response.Headers.Add("X-Pagination", JsonConvert.SerializeObject(metadata));
            // Restituiamo Ok con la lista di hotels.
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
