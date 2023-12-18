using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using TaurusMessenger.Shared.Model;
using TaurusMessengerServer.Service;

namespace TaurusMessengerServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly DatabaseService database;
        private readonly IConfiguration config;
        public AuthController(DatabaseService msc, IConfiguration configuration)
        {
            database = msc;
            config = configuration;
        }

        [HttpGet("getinfo")]
        public IActionResult Get()
        {
            return Ok($"{nameof(AuthController)} work fine.");
        }

        [HttpPost("register")]
        public async Task<ActionResult<string>> Register(UserAuthData inputData)
        {
            return Ok(GenerateToken(inputData)); //TODO: registration
        }

        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserAuthData inputData)
        {
            var result = database.GetUser(inputData.Login);
            if (result == null)
            {
                return BadRequest(result);
            }

            return Ok(GenerateToken(inputData));  //TODO: implement JWT auth
        }

        private string GenerateToken(UserAuthData user)
        {
            var key = config["JwtSettings:Key"]!;
            var issuer = config["JwtSettings:Issuer"]!;
            var audience = config["JwtSettings:Audience"]!;

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            List<Claim> claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Iss, issuer),
                new Claim(JwtRegisteredClaimNames.Aud, audience),
                //new Claim(ClaimTypes.Name, "John") and other user data
            };

            var token = new JwtSecurityToken(
                claims: claims,
                issuer: issuer,
                audience: audience,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: credentials);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}
