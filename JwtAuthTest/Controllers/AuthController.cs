using JwtAuthTest.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly JwtService _jwtService;

    public AuthController(JwtService jwtService)
    {
        _jwtService = jwtService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginModel model)
    {
        if (model.Username == "string" && model.Password == "string") // Sabit kullanıcı ve parola
        {
            var token = _jwtService.GenerateToken(model.Username);
            return Ok(new { Token = token });
        }

        return Unauthorized();
    }
    
    
    [HttpGet("CheckAuth")]
    [Authorize] // Bu attribute, oturum doğrulaması için token gerektirir
    public IActionResult CheckAuth()
    {
        return Ok("Oturum geçerli!");
    }
}

public class LoginModel
{
    public string Username { get; set; }
    public string Password { get; set; }
}