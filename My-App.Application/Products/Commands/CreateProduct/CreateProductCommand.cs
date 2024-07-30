using FluentValidation;
using Microsoft.Extensions.Logging;
using My_App.Application.Core.Abstractions.Data;
using My_App.Application.Core.Abstractions.Messaging;
using My_App.Domain.Products;

namespace My_App.Application.Products.Commands.CreateProduct;

public sealed record CreateProductCommand(
    string Name, 
    string Description, 
    decimal Price, 
    int Stock) : ICommand;

internal sealed class CreateProductCommandHandler : ICommandHandler<CreateProductCommand>
{
    private readonly IProductRepository _productRepository;
    private readonly 
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<CreateProductCommandHandler> _logger;

    public Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

internal sealed class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(product => product.Name).NotNull().NotEmpty().WithMessage("Product Name can't be null or empty.");

        RuleFor(product => product.Name).NotNull().NotEmpty().WithMessage("Product Name can't be null or empty.");

        RuleFor(product => product.Name).NotNull().NotEmpty().WithMessage("Product Name can't be null or empty.");

        RuleFor(product => product.Name).NotNull().NotEmpty().WithMessage("Product Name can't be null or empty.");
    }
}
