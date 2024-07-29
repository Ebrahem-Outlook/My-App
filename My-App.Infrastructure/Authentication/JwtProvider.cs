using My_App.Application.Core.Abstractions.Authentication;
using My_App.Domain.Users;

namespace My_App.Infrastructure.Authentication;

internal sealed class JwtProvider : IJwtProvider
{
    public Task<string> GenerateToken(User user)
    {
        throw new NotImplementedException();
    }
}
