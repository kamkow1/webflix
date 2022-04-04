using Microsoft.AspNetCore.Mvc;
using webflix_server.Data.Models;
using webflix_server.Services;

namespace webflix_server.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(User user)
    {
       var foundUser =  await _userService.FindOne(user.Email);

       if (foundUser is null)
           return Conflict();

       return Ok(new { message = "registration was successful" });
    }
}