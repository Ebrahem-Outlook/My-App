using Microsoft.Extensions.Caching.Distributed;
using My_App.Domain.Products;
using My_App.Infrastructure.Repositories;

namespace My_App.Infrastructure.Caching;

internal sealed class CachedProductRepository(ProductRepository decorated, IDistributedCache cache) : IProductRepository
{
    public Task AddAsync(Product product, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Product product, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<List<Product>?> GetAllAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<Product?> GetByIdAsync(Guid productId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task<List<Product>?> GetByUserIdAsync(Guid userId, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task Update(Product product, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}
