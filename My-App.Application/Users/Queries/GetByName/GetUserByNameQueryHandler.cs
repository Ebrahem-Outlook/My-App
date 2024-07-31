using My_App.Application.Core.Abstractions.Messaging;
using My_App.Application.Users.Queries.GetAll;
using My_App.Domain.Users;

namespace My_App.Application.Users.Queries.GetByName;

internal sealed class GetUserByNameQueryHandler : IQueryHandler<GetUserByNameQuery, List<UserDTO>>
{
    private readonly IUserRepository _userRepository;

    public GetUserByNameQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Task<List<UserDTO>> Handle(GetUserByNameQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
