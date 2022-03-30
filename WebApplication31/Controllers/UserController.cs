using Microsoft.AspNetCore.Mvc;
using WebApplication31.Interfaces.Services;
using WebApplication31.Models;

namespace WebApplication31.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_userService.GetUsers());
        }
        [HttpGet("/{id}")]
        public IActionResult GetUser(int id)
        {
            var user = _userService.GetUser(id);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();

        }
        [HttpDelete("/{id}")]
        public IActionResult DeleteUser(int id)
        {
            _userService.Delete(id);
            return Ok();
        }
        [HttpPost]
        public IActionResult AddUser([FromBody]User user)
        {
            _userService.Add(user);
            return Ok();
        }
    }
}
