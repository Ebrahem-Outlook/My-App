namespace My_App.Application.Core.Abstractions.Authentication;

public interface IUserIdentityProvider
{
    Guid UserId { get; }
}
