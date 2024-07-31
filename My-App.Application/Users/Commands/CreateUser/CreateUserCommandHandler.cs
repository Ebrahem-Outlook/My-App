using Microsoft.Extensions.Logging;
using My_App.Application.Core.Abstractions.Authentication;
using My_App.Application.Core.Abstractions.Data;
using My_App.Application.Core.Abstractions.Emails;
using My_App.Application.Core.Abstractions.Messaging;
using My_App.Domain.Core.TypeBase.Result;
using My_App.Domain.Users;

namespace My_App.Application.Users.Commands.CreateUser;

internal sealed class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
{
    private readonly IUserRepository _userRepository;
    private readonly IJwtProvider _jwtProvider;
    private readonly IEmailService _emailService;
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<CreateUserCommandHandler> _logger;

    public CreateUserCommandHandler(IUserRepository userRepository, IJwtProvider jwtProvider, IEmailService emailService, IUnitOfWork unitOfWork, ILogger<CreateUserCommandHandler> logger)
    {
        _userRepository = userRepository;
        _jwtProvider = jwtProvider;
        _emailService = emailService;
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    public async Task<Result> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Command Started {RequestName}, {DateTime}", typeof(CreateUserCommand).Name, DateTime.UtcNow);

        User? user = User.Create(request.FirstName, request.LastName, request.Email, request.Password);

        if (user is null)
        {
            _logger.LogInformation("Command Started {RequestName}, {DateTime}", typeof(CreateUserCommand).Name, DateTime.UtcNow);
        }

        await _userRepository.AddAsync(user, cancellationToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        await _emailService.SendEmailAsync("outlook@gmail.com", "Hello Ebrahem", "Hello Ebrahem there are new User Created in your system");

        string token = _jwtProvider.GenerateToken(user);

        _logger.LogInformation("Command Started {RequestName}, {DateTime}", typeof(CreateUserCommand).Name, DateTime.UtcNow);

        return Result.Success();
    }
}
