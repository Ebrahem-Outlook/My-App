using My_App.Application.Core.Abstractions.Messaging;

namespace My_App.Application.Users.Commands.UpdatePassword;

public sealed record UpdatePasswordCommand(Guid UserId, string Password) : ICommand;


