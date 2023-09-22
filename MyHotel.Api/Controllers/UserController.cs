using Microsoft.AspNetCore.Mvc;
using PlanBetter.Business.Models;
using PlanBetter.Business.Services.IServices;
using PlanBetter.Domain.Entities;
namespace PlanBetter.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_userService.GetAllUsers());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userService.GetUserbyId(id);
          
                return Ok(user);
         
        }
        [HttpGet("email/{email}")]
        public IActionResult GetByEmail(string email, string password)
        {
            var user = _userService.GetUserbyEmai(email,password);
            if (user != null)
            {
                return Ok(user);
            }

            return NotFound();
        }
        [HttpPost("email/{email},password/{password}")]
        public IActionResult GetCredentials(string email,string password)
        {
            var user = 3;
            user = _userService.GetUserbyEmai(email,password);
            if (user !=3)
            {
                return Ok(user);
            }

            return Ok(user);
        }
        [HttpPost]
        public IActionResult AddUser([FromBody] UserModel model)
        {
            return CreatedAtAction(null,_userService.AddUser(model));
        }
        [HttpPut]
        public IActionResult Update([FromBody] User model)
        {
            _userService.Update(model);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _userService.Delete(id);
            return NoContent() ;
        }
    }
}
