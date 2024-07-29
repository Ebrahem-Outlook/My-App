using My_App.Application.Core.Abstractions.Messaging;
using My_App.Application.Users.Queries.GetAll;

namespace My_App.Application.Users.Queries.GetById;

public sealed record GetUserByIdQuery(Guid UserId) : IQuery<UserDTO>;
