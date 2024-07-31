using My_App.Application.Core.Abstractions.Messaging;

namespace My_App.Application.Products.Commands.DeleteProduct;

public sealed record DeleteProductCommand(Guid ProductId) : ICommand;
