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

    public async Task<List<UserDTO>> Handle(GetUserByNameQuery request, CancellationToken cancellationToken)
    {
        List<User>? users = await _userRepository.GetByNameAsync(request.Name, cancellationToken);

        if (users is null)
        {
            throw new NullReferenceException();
        }

        List<UserDTO> userDTOs = new List<UserDTO>(users.Count);

        foreach(User user in users)
        {
            UserDTO userDTO = new(user.Id, user.FirstName, user.LastName, user.Email, user.Password);

            userDTOs.Add(userDTO);
        }

        return userDTOs;
    }
}
