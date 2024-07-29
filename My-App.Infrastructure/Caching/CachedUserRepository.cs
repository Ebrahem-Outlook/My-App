using Microsoft.Extensions.Caching.Distributed;
using My_App.Domain.Users;
using My_App.Infrastructure.Repositories;

namespace My_App.Infrastructure.Caching;

internal sealed class CachedUserRepository(UserRepository decorated, IDistributedCache cache) : IUserRepository
{
    public async Task AddAsync(User user, CancellationToken cancellationToken = default)
    {
        await decorated.AddAsync(user, cancellationToken);
        string key = $"Key-{user.Id}";
        await cache.RemoveAsync(key, cancellationToken);
    }

    public async Task Update(User user, CancellationToken cancellationToken = default)
    {
        await decorated.Update(user, cancellationToken);
        string key = $"Key-{user.Id}";
        await cache.RemoveAsync(key, cancellationToken);
    }

    public async Task Delete(User user, CancellationToken cancellationToken = default)
    {
        await decorated.Delete(user, cancellationToken);
        string key = $"Key-{user.Id}";
        await cache.RemoveAsync(key, cancellationToken);
    }

    public async Task<List<User>?> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await decorated.GetAllAsync(cancellationToken);
    }

    public async Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default)
    {
        return await decorated.GetByEmailAsync(email, cancellationToken);
    }

    public async Task<User?> GetByIdAsync(Guid userId, CancellationToken cancellationToken = default)
    {
        return await decorated.GetByIdAsync(userId, cancellationToken);
    }

    public async Task<List<User>?> GetByNameAsync(string name, CancellationToken cancellationToken = default)
    {
        return await decorated.GetByNameAsync(name, cancellationToken);
    }
}
