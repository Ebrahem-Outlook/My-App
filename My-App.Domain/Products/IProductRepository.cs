namespace My_App.Domain.Products;

public interface IProductRepository
{
    // Commands.
    Task AddAsync(Product product, CancellationToken cancellationToken = default);
    Task Update(Product product, CancellationToken cancellationToken = default);
    Task Delete(Product product, CancellationToken cancellationToken = default);

    // Queries.
    Task<List<Product>?> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Product?> GetByIdAsync(Guid productId, CancellationToken cancellationToken = default);
    Task<List<Product>?> GetByUserIdAsync(Guid userId, CancellationToken cancellationToken = default);
}
