using My_App.Application.Core.Abstractions.Messaging;

namespace My_App.Application.Products.Commands.UpdateProduct;

public sealed record UpdateProductCommand(
    Guid ProductId,
    string Name,
    string Description,
    decimal Price,
    int Stock) : ICommand;
