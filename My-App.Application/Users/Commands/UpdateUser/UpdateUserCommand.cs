using My_App.Application.Core.Abstractions.Messaging;

namespace My_App.Application.Users.Commands.UpdateUser;

public sealed record UpdateUserCommand(
    Guid UserId, 
    string FirstName, 
    string LastName) : ICommand;
