using My_App.Application.Core.Abstractions.Messaging;

namespace My_App.Application.Users.Commands.CreateUser;

public sealed record CreateUserCommand(
    string FirstName, 
    string LastName, 
    string Email,
    string Password) : ICommand;
