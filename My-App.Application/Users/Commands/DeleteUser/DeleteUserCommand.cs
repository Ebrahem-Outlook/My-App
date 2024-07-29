using My_App.Application.Core.Abstractions.Messaging;

namespace My_App.Application.Users.Commands.DeleteUser;

public sealed record DeleteUserCommand(Guid UserId) : ICommand;
