using Microsoft.EntityFrameworkCore;
using My_App.Application.Core.Abstractions.Data;
using My_App.Domain.Products;

namespace My_App.Infrastructure.Repositories;

internal sealed class ProductRepository(IDbContext dbContext) : IProductRepository
{
    public async Task AddAsync(Product product, CancellationToken cancellationToken = default)
    {
        await dbContext.Set<Product>().AddAsync(product, cancellationToken);
    }

    public async Task Update(Product product, CancellationToken cancellationToken = default)
    {
        dbContext.Set<Product>().Update(product);

        await Task.CompletedTask;
    }

    public async Task Delete(Product product, CancellationToken cancellationToken = default)
    {
        dbContext.Set<Product>().Remove(product);

        await Task.CompletedTask;
    }

    public async Task<List<Product>?> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await dbContext.Set<Product>().ToListAsync(cancellationToken);
    }

    public async Task<List<Product>?> GetByUserIdAsync(Guid userId, CancellationToken cancellationToken = default)
    {
        return await dbContext.Set<Product>().Where(product => product.UserId == userId).ToListAsync(cancellationToken);
    }

    
}
