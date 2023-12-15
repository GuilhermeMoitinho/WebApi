using Api_Ben10.Auth;
using Api_Ben10.Domain.Entities;
using ApiBen10.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiBen10.Domain.Entities;
using Aliens = ApiBen10.Domain.Entities;



namespace Api_Ben10.Controllers
{
    [Route("api/v1/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public IActionResult Auth([FromBody] AuthAlien model)
        {
            if (model.Username == "guilherme" && model.Password == "123456")
            {
                var token = TokenServices.GenerateToken(new Aliens.Alien());
                return Ok(token);
            }

            return BadRequest("username or password invalid");
        }
    }
}
