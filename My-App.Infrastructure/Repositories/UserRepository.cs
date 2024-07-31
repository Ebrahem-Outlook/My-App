using Microsoft.EntityFrameworkCore;
using My_App.Application.Core.Abstractions.Data;
using My_App.Domain.Users;

namespace My_App.Infrastructure.Repositories;

internal sealed class UserRepository(IDbContext dbContext) : IUserRepository
{
    // Commands.
    public async Task AddAsync(User user, CancellationToken cancellationToken = default)
    {
        await dbContext.Set<User>().AddAsync(user, cancellationToken);
    }

    public async Task Update(User user, CancellationToken cancellationToken = default)
    {
        dbContext.Set<User>().Update(user);

        await Task.CompletedTask;
    }

    public async Task Delete(User user, CancellationToken cancellationToken = default)
    {
        dbContext.Set<User>().Remove(user);

        await Task.CompletedTask;
    }

    // Queries.
    public async Task<List<User>?> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await dbContext.Set<User>().ToListAsync(cancellationToken);
    }

    public async Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default)
    {
        return await dbContext.Set<User>().FirstOrDefaultAsync(user => user.Email == email, cancellationToken);
    }

   

    public async Task<List<User>?> GetByNameAsync(string name, CancellationToken cancellationToken = default)
    {
        return await dbContext.Set<User>().Where(user => user.FirstName == name).ToListAsync(cancellationToken);
    }
}
