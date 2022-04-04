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

       if (foundUser is not null)
           return Conflict();

       await _userService.RegisterUser(user);

       return Ok(new { message = "registration was successful" });
    }
}