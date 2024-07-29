namespace My_App.Application.Users.Queries.GetAll;

public sealed record UserDTO(
    Guid UserId, 
    string FirstName, 
    string LastName, 
    string Email, 
    string Password);
