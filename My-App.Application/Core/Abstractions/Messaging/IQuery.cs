using MediatR;
using My_App.Domain.Core.TypeBase.Result;

namespace My_App.Application.Core.Abstractions.Messaging;

public interface IQuery : IRequest<Result>
{

}

public interface IQuery<out TResponse> : IRequest<TResponse>
    where TResponse : class
{
    
}
