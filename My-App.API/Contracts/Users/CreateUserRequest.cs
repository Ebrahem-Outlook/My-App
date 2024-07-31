namespace My_App.API.Contracts.Users;

public sealed record CreateUserRequest(
    string FirstName, 
    string LastName, 
    string Email, 
    string Passsword);
