using FluentValidation;

namespace My_App.Application.Products.Commands.CreateProduct;

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
