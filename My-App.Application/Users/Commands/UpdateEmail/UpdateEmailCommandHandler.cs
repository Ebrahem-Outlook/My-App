using My_App.Application.Core.Abstractions.Messaging;

namespace My_App.Application.Users.Commands.UpdateEmail;

internal sealed class UpdateEmailCommandHandler : ICommandHandler<UpdateEmailCommand>
{
    public Task Handle(UpdateEmailCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
