using MediatR;
using My_App.Domain.Core.TypeBase.Result;

namespace My_App.Application.Core.Abstractions.Messaging;

public interface ICommand : IRequest<Result>
{

}

public interface ICommand<out TResponse> : IRequest<TResponse>
    where TResponse : Result<TResponse>
{

}
