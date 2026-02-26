using Microsoft.AspNetCore.Mvc;
using TaskManagementCore.Models;
using System.ComponentModel;
using TaskManagementCore.Services.Interfaces;
using TaskManagementCore.DTO;
using Microsoft.AspNetCore.Identity.Data;
namespace TaskManagementAPI.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("validate/{username}")]
        public async Task<ActionResult<bool>> Validate(string username)
        {
            return Ok(await _userService.Validate(username));
        }

        [HttpPost("auth")]
        public async Task<ActionResult<UserData>> Authenticate([FromBody] LoginRequestDTO login)
        {
            var user = await _userService.Authenticate(login.Username, login.Password);
            if (user == null)
                return Unauthorized();
            return Ok(user);
        }

        [HttpPut("changePassword")]
        public async Task<IActionResult> ChangePassword([FromBody] ChangePasswordDTO dto)
        {
            await _userService.ChangePassword(dto.Username, dto.NewPassword);
            return Ok();
        }

        [HttpGet("{userType}")]
        public async Task<ActionResult<BindingList<UserData>>> GetAll(string userType)
        {
            var users = await _userService.GetAll(userType);
            return Ok(users);

        }
    }
}
