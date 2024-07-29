using My_App.Application.Core.Abstractions.Messaging;
using My_App.Application.Users.Queries.GetAll;

namespace My_App.Application.Users.Queries.GetByName;

public sealed record GetUserByNameQuery(string Name) : IQuery<List<UserDTO>>;
