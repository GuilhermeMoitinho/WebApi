using ApiBen10.Domain.Entities;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Aliens = ApiBen10.Domain.Entities;


namespace Api_Ben10.Auth
{
    public static class TokenServices
    {
        public static string GenerateToken(Aliens.Alien user)
        {
            var secretKey = Key.Secret;
            var expirationTimeInHours = 48;

            var tokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(secretKey);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("alienId", user.Id.ToString())
                }),

                Expires = DateTime.UtcNow.AddHours(expirationTimeInHours),
                SigningCredentials = new SigningCredentials
                (new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
