using MediatR;

namespace My_App.Application.Core.Abstractions.Messaging;

public interface IQueryHandler<TQuery> : IRequestHandler<TQuery>
    where TQuery : IQuery
{

}

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, TResponse>
    where TQuery : IQuery<TResponse>
    where TResponse : class
{

}
