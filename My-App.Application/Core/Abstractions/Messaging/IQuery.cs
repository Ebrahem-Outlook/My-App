using MediatR;

namespace My_App.Application.Core.Abstractions.Messaging;

public interface IQuery : IRequest
{

}

public interface IQuery<out TResponse> : IRequest<TResponse>
    where TResponse : class
{
    
}
