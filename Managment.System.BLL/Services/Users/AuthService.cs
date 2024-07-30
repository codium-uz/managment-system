using Managment.System.BLL.Interfaces.Users;
using Managment.System.Domain.Entities.UserEntities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;

namespace Managment.System.BLL.Services.Users;

public class AuthService : IAuthService
{
    private IConfigurationSection configuration;

    public AuthService(IConfiguration configuration)
    {
        this.configuration = configuration.GetSection("JWT");
    }
    public string GenerateToken(User user)
    {
        var claims = new[]
        {
            new Claim("Id", user.Id.ToString()),
            new Claim(ClaimTypes.Name, user.UserName),
            new Claim(ClaimTypes.Role, user.UserRoles.ToString())
        };

        var secutiryKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["SigningKey"]));
        var credentials = new SigningCredentials(secutiryKey, SecurityAlgorithms.HmacSha256Signature);
        var tokenDestrictor = new JwtSecurityToken(
            configuration["Issuer"],
            configuration["Audience"],
            claims,
            expires: DateTime.UtcNow.AddMinutes(double.Parse(configuration["ExpiresInSeconds"])),
            signingCredentials: credentials);

        return new JwtSecurityTokenHandler().WriteToken(tokenDestrictor);
    }
}
