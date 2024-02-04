using Freelance.Application.Authentication.Common.Interfaces;
using Freelance.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Freelance.Infrastructure.Persistence.Jwt;

public class JwtTokenGenerator : IJwtTokenGenerator
{
    private readonly JwtSettings _jwtSettings;
    private readonly UserManager<IdentityUser> _userManager;

    public JwtTokenGenerator(IOptions<JwtSettings> jwtOptions, UserManager<IdentityUser> userManager)
    {
        _jwtSettings = jwtOptions.Value;
        _userManager = userManager;
    }

    public async Task<string> GenerateToken(User user)
    {
        var identityUser = await _userManager.FindByEmailAsync(user.Email);
        var roles = await _userManager.GetRolesAsync(identityUser);
        var roleClaims = new List<Claim>();
        foreach (var role in roles)
        {
            roleClaims.Add(new Claim(ClaimTypes.Role, role));
        };

        var claims = new[]
        {
            new Claim("FirstName", user.FirstName),
            new Claim("LastName", user.FirstName),
            new Claim(JwtRegisteredClaimNames.Email, user.Email),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        }.Union(roleClaims);

        var signinCredentials = new SigningCredentials(
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwtSettings.Secret)),
            SecurityAlgorithms.HmacSha256);

        var securetyToken = new JwtSecurityToken(
            issuer: _jwtSettings.Issuer,
            audience: _jwtSettings.Audience,
            expires: DateTime.UtcNow.AddMinutes(_jwtSettings.ExpiryMinutes),
            signingCredentials: signinCredentials,
            claims: claims
            );

        return new JwtSecurityTokenHandler().WriteToken(securetyToken);
    }
}

