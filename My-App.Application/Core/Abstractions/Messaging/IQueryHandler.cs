using MediatR;
using My_App.Domain.Core.TypeBase.Result;

namespace My_App.Application.Core.Abstractions.Messaging;

public interface IQueryHandler<TQuery> : IRequestHandler<TQuery, Result>
    where TQuery : IQuery
{

}

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
    where TQuery : IQuery<TResponse>
    where TResponse : Result<TResponse>
{

}
