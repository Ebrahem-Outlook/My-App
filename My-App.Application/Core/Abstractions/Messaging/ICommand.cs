using MediatR;

namespace My_App.Application.Core.Abstractions.Messaging;

public interface ICommand : IRequest
{

}

public interface ICommand<out TResponse> : IRequest<TResponse>
    where TResponse : class
{

}
