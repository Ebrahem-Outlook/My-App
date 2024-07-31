using My_App.Application.Core.Abstractions.Messaging;

namespace My_App.Application.Products.Commands.CreateProduct;

public sealed record CreateProductCommand(
    string Name, 
    string Description, 
    decimal Price, 
    int Stock) : ICommand;
