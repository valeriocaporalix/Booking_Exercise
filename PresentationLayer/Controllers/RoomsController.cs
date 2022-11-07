using Booking_Exercise.BusinessLayer.Interfaces;
using Booking_Exercise.Models.RoomModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Exercise.PresentationLayer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        private IRoomService _roomService;

        public RoomsController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] PostRoomDto postRoom)
        {
            try
            {
                var roomToAdd = _roomService.Post(postRoom);               
                return CreatedAtAction(nameof(GetById),
                    new
                    {
                        id = roomToAdd.RoomId
                    },
                    roomToAdd);
            }
            catch (InvalidOperationException)
            {
                return BadRequest("No hotel with such id");
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                var room = _roomService.GetById(id);
                return Ok(room);
            }
            catch (Exception)
            {
                return NotFound("No room with such id");
            }

        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var rooms = _roomService.GetAll();
            return Ok(rooms);
        }
    }
}
