using My_App.Application.Core.Abstractions.Messaging;
using My_App.Domain.Core.TypeBase.Result;

namespace My_App.Application.Products.Commands.DeleteProduct;

internal sealed class DeleteProductCommandHandler : ICommandHandler<DeleteProductCommand>
{
    public Task<Result> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
