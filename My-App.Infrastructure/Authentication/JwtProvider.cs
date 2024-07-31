using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using My_App.Application.Core.Abstractions.Authentication;
using My_App.Domain.Users;
using My_App.Infrastructure.Authentication.Settings;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace My_App.Infrastructure.Authentication;

internal sealed class JwtProvider : IJwtProvider
{
    private readonly JwtSettings _jwtSettings;

    public JwtProvider(IOptions<JwtSettings> jwtSettings)
    {
        _jwtSettings = jwtSettings.Value;
    }

    public string GenerateToken(User user)
    {
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.SecurityKey));

        var signingCredentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

        Claim[] claims =
        {
            new Claim("userId", user.Id.ToString()),
            new Claim("email", user.Email),
            new Claim("name", user.FirstName)
        };

        DateTime tokeExpirationTime = DateTime.UtcNow.AddMinutes(_jwtSettings.TokenExpirationInMinutes);

        var token = new JwtSecurityToken(
            _jwtSettings.Issuer,
            _jwtSettings.Audience,
            claims,
            null,
            tokeExpirationTime,
            signingCredentials);

        string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);

        return tokenValue;
    }
}
