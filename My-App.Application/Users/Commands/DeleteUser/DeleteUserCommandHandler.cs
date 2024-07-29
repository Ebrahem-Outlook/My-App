using My_App.Application.Core.Abstractions.Data;
using My_App.Application.Core.Abstractions.Messaging;
using My_App.Domain.Users;

namespace My_App.Application.Users.Commands.DeleteUser;

internal sealed class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        User? user = await _userRepository.GetByIdAsync(request.UserId, cancellationToken);

        if (user is null)
        {
            throw new ArgumentNullException();
        }

        await _userRepository.Delete(user, cancellationToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
