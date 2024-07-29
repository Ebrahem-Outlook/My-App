using My_App.Application.Core.Abstractions.Messaging;

namespace My_App.Application.Users.Commands.UpdateEmail;

public sealed record UpdateEmailCommand(Guid UserId, string Email) : ICommand;
