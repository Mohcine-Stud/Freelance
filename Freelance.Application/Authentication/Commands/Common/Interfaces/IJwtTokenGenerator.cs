
using Freelance.Domain.Models;

namespace Freelance.Application.Authentication.Common.Interfaces;

public interface IJwtTokenGenerator
{
    Task<string> GenerateToken(User user);
}
