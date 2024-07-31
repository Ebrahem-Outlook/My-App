using My_App.Application.Core.Abstractions.Messaging;
using My_App.Domain.Products;

namespace My_App.Application.Products.Queries.GetAll;

public sealed record GetAllProductsQuery : IQuery<List<Product>>;


