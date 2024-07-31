using My_App.Application.Core.Abstractions.Messaging;
using My_App.Domain.Users;

namespace My_App.Application.Users.Queries.GetAll;

internal sealed class GetAllUsersQueryHandler : IQueryHandler<GetAllUsersQuery, List<UserDTO>>
{
    private readonly IUserRepository _userRepository;

    public GetAllUsersQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Task<List<UserDTO>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
