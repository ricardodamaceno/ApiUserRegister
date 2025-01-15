using ApiUserRegister.Models.Domain;
using ApiUserRegister.Services.Interfaces;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;

namespace ApiUserRegister.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AuthController : ControllerBase
	{
		private readonly IUserService _userService;

		public AuthController(IUserService userService)
		{
			_userService = userService;
		}

		[HttpPost("register")]
		public async Task<IActionResult> Register([FromBody] AuthRequest request)
		{
			var success = await _userService.RegisterAsync(request.Username, request.Password);
			if (!success) return BadRequest("Username already exists.");

			return Ok("User registered successfully.");
		}

		[HttpPost("login")]
		public async Task<IActionResult> Login([FromBody] AuthRequest request)
		{
			var success = await _userService.LoginAsync(request.Username, request.Password);
			if (!success) return Unauthorized("Invalid username or password.");

			return Ok("Login successful.");
		}
	}
}
