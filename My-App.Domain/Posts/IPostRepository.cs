namespace My_App.Domain.Posts;

public interface IPostRepository
{
    // Commands.
    Task AddAsync(Post post, CancellationToken cancellationToken = default);
    Task Update(Post post, CancellationToken cancellationToken = default);
    Task Delete(Post post, CancellationToken cancellationToken = default);

    // Queries.
    Task<Post> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<List<Post>> GetByAutherIdAsync(Guid id, CancellationToken cancellationToken = default);
}
