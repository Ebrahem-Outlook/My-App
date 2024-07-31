using Microsoft.Extensions.Logging;
using My_App.Application.Core.Abstractions.Authentication;
using My_App.Application.Core.Abstractions.Messaging;
using My_App.Domain.Products;

namespace My_App.Application.Products.Queries.GetAll;

internal sealed class GetAllProductsQueryHandler : IQueryHandler<GetAllProductsQuery, List<Product>>
{
    private readonly IProductRepository _productRepository;
    private readonly IJwtProvider jwtProvider;
    private readonly ILogger<GetAllProductsQueryHandler> _logger;

    public GetAllProductsQueryHandler(IProductRepository productRepository, IJwtProvider jwtProvider, ILogger<GetAllProductsQueryHandler> logger)
    {
        _productRepository = productRepository;
        this.jwtProvider = jwtProvider;
        _logger = logger;
    }

    public Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}

