using My_App.Application.Core.Abstractions.Messaging;
using My_App.Application.Users.Queries.GetAll;
using My_App.Domain.Users;

namespace My_App.Application.Users.Queries.GetByEmail;

internal sealed class GetUserByEmailQueryHandler : IQueryHandler<GetUserByEmailQuery, UserDTO>
{
    private readonly IUserRepository _userRepository;

    public GetUserByEmailQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<UserDTO> Handle(GetUserByEmailQuery request, CancellationToken cancellationToken)
    {
        User? user = await _userRepository.GetByEmailAsync(request.Email, cancellationToken);

        if (user is null)
        {
            throw new ArgumentNullException();
        }

        return new(user.Id, user.FirstName, user.LastName, user.Email, user.Password);
    }
}
