using Api_Ben10.Auth;
using ApiBen10.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api_Ben10.Controllers
{
    [Route("api/v1/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public IActionResult Auth(string username, string password)
        {
            if (username == "guilherme" && password == "123456")
            {
                var token = TokenServices.GenerateToken(new Alien());
                return Ok(token);
            }

            return BadRequest("username or password invalid");
        }
    }
}
