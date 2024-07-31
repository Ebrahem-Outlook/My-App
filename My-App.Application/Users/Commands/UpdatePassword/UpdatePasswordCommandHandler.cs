using Microsoft.Extensions.Logging;
using My_App.Application.Core.Abstractions.Authentication;
using My_App.Application.Core.Abstractions.Data;
using My_App.Application.Core.Abstractions.Messaging;
using My_App.Domain.Users;

namespace My_App.Application.Users.Commands.UpdatePassword;

internal sealed class UpdatePasswordCommandHandler : ICommandHandler<UpdatePasswordCommand>
{
    private readonly IUserRepository _userRepository;
    private readonly IJwtProvider _jwtProvider;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<UpdatePasswordCommandHandler> _logger;

    public UpdatePasswordCommandHandler(IUserRepository userRepository, IJwtProvider jwtProvider, IUnitOfWork unitOfWork, ILogger<UpdatePasswordCommandHandler> logger)
    {
        _userRepository = userRepository;
        _jwtProvider = jwtProvider;
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public Task Handle(UpdatePasswordCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
