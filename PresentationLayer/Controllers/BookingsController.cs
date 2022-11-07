using Booking_Exercise.BusinessLayer;
using Booking_Exercise.BusinessLayer.Interfaces;
using Booking_Exercise.Models.BookingModels;
using Booking_Exercise.Models.HotelModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Booking_Exercise.PresentationLayer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private IBookingService _bookingService;

        public BookingsController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var bookings = _bookingService.GetAllBookings();
            return Ok(bookings);
        }

        [HttpGet("{bookingId}")]
        public IActionResult GetDetails(int bookingId)
        {
            try
            {
                var bookingFound = _bookingService.GetBookingById(bookingId);
                return Ok(bookingFound);
            }
            catch(InvalidOperationException)
            {
                return NotFound("No booking with such id");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] PostBookingDto postBooking)
        {
            try
            {
                var bookingAdded = _bookingService.InsertBooking(postBooking);
                return Created($"{bookingAdded.BookingId}", bookingAdded);
            }
            catch(DbUpdateException)
            {
                return BadRequest("No user with such id");
            }
        }

        [HttpPut("{bookingId}/addRoom/{roomId}")]
        public IActionResult AddRoom(int bookingId, int roomId)
        {
            try
            {
                _bookingService.AddRoomToBooking(bookingId, roomId);
                return NoContent();
            }
            catch(Exception)
            {
                return BadRequest("No booking or room with such id");
            }
        }

        [HttpPut("{bookingId}/removeRoom/{roomId}")]
        public IActionResult RemoveRoom(int bookingId, int roomId)
        {
            try
            {
                _bookingService.RemoveRoomToBooking(bookingId, roomId);
                return NoContent();
            }
            catch (Exception)
            {
                return BadRequest("No booking or room with such id");
            }
        }

        [HttpDelete("{bookingId}")]
        public IActionResult Delete(int bookingId)
        {
            try
            {
                _bookingService.DeleteBooking(bookingId);
                return NoContent();
            }
            catch(InvalidOperationException)
            {
                return BadRequest("No booking with such id");
            }
        }

        [HttpPut("{bookingId}")]
        public IActionResult Put([FromBody] PutBookingDto postBooking, int bookingId)
        {
            try
            {
                var bookingToPost = _bookingService.UpdateBooking(postBooking, bookingId);
                return NoContent();
            }
            catch (InvalidOperationException)
            {
                return BadRequest("No booking with such id");
            }
        }
    }
}
