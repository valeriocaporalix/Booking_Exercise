using Booking_Exercise.BusinessLayer.Interfaces;
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
    }
}
