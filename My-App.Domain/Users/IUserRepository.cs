namespace My_App.Domain.Users;

public interface IUserRepository
{
    // Commands.
    Task AddAsync(User user, CancellationToken cancellationToken = default);
    Task Update(User user, CancellationToken cancellationToken = default);
    Task Delete(User user, CancellationToken cancellationToken = default);

    // Queries.
    Task<List<User>?> GetAllAsync(CancellationToken cancellationToken = default);
    Task<User?> GetByIdAsync(Guid userId, CancellationToken cancellationToken = default);
    Task<User?> GetByEmailAsync(string email, CancellationToken cancellationToken = default);
    Task<List<User>?> GetByNameAsync(string name, CancellationToken cancellationToken = default);
}
