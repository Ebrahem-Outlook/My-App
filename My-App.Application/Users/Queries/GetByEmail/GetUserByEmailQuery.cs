using My_App.Application.Core.Abstractions.Messaging;
using My_App.Application.Users.Queries.GetAll;

namespace My_App.Application.Users.Queries.GetByEmail;

public sealed record GetUserByEmailQuery(string Email) : IQuery<UserDTO>;
