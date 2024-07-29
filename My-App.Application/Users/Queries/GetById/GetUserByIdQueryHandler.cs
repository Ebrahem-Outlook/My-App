using My_App.Application.Core.Abstractions.Messaging;
using My_App.Application.Users.Queries.GetAll;

namespace My_App.Application.Users.Queries.GetById;

internal sealed class GetUserByIdQueryHandler : IQueryHandler<GetUserByIdQuery, UserDTO>
{
    public Task<UserDTO> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
