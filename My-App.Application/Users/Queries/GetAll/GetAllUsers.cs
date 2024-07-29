using My_App.Application.Core.Abstractions.Messaging;

namespace My_App.Application.Users.Queries.GetAll;

public sealed record GetAllUsersQuery : IQuery<List<UserDTO>>;
