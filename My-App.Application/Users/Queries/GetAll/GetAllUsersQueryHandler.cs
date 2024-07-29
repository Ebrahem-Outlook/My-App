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

    public async Task<List<UserDTO>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        List<User>? users = await _userRepository.GetAllAsync(cancellationToken);

        if (users is null)
        {
            throw new NullReferenceException();
        }

        List<UserDTO> userDTOs = new List<UserDTO>(users.Count);

        foreach (var user in users) 
        {
            UserDTO userDTO = new(user.Id, user.FirstName, user.LastName, user.Email, user.Password);

            userDTOs.Add(userDTO);
        }

        return userDTOs;
    }
}
