using My_App.Application.Core.Abstractions.Messaging;
using My_App.Domain.Core.TypeBase.Result;

namespace My_App.Application.Users.Commands.UpdateEmail;

internal sealed class UpdateEmailCommandHandler : ICommandHandler<UpdateEmailCommand>
{
    public Task<Result> Handle(UpdateEmailCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
