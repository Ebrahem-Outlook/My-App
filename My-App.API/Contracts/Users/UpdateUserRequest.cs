namespace My_App.API.Contracts.Users;

public sealed record UpdateUserRequest(
    Guid UserId, 
    string FirstName, 
    string LastName);
