using FluentValidation;

namespace My_App.Application.Products.Commands.UpdateProduct;

internal sealed class UpdateProductCommandValidator : AbstractValidator<UpdateProductCommand>
{
    public UpdateProductCommandValidator()
    {
        RuleFor(product => product.ProductId).NotNull().NotEmpty().WithMessage("Product Id can't be null or empty.");

        RuleFor(product => product.Name).NotNull().NotEmpty().WithMessage("Product Name can't be null or empty.");

        RuleFor(product => product.Description).NotNull().NotEmpty().WithMessage("Product Description can't be null or empty.");

        RuleFor(product => product.Price).NotNull().NotEmpty().WithMessage("Product Price can't be null or empty.");

        RuleFor(product => product.Stock).NotNull().NotEmpty().WithMessage("Product Stock can't be null or empty.");
    }
}
