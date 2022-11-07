using Booking_Exercise.BusinessLayer.Interfaces;
using Booking_Exercise.Models.UserModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Exercise.PresentationLayer.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] PostUserDto postUser)
        {  
                var userToAdd = _userService.Post(postUser);
            return Created("", userToAdd);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetDetail(int id)
        {
            try
            {
                var user = _userService.GetById(id);
                return Ok(user);

            }catch(Exception e)
            {
                return NotFound("No user with such id");
            }
        }
    }
}
