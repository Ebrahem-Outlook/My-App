namespace My_App.API.Contracts.Users;

public sealed record UpdatedPasswordRequest(
    Guid UserId,
    string Password);
