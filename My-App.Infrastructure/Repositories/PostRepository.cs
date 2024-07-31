using Microsoft.EntityFrameworkCore;
using My_App.Application.Core.Abstractions.Data;
using My_App.Domain.Posts;

namespace My_App.Infrastructure.Repositories;

internal sealed class PostRepository(IDbContext dbContext) : IPostRepository
{
    public async Task AddAsync(Post post, CancellationToken cancellationToken = default)
    {
        await dbContext.Set<Post>().AddAsync(post, cancellationToken);
    }

    public async Task Update(Post post, CancellationToken cancellationToken = default)
    {
        dbContext.Set<Post>().Update(post);

        await Task.CompletedTask;
    }

    public async Task Delete(Post post, CancellationToken cancellationToken = default)
    {
        dbContext.Set<Post>().Remove(post);

        await Task.CompletedTask;
    }

    public async Task<List<Post>?> GetByAutherIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await dbContext.Set<Post>().Where(post => post.AuthorId == id).ToListAsync(cancellationToken);
    }

    public async Task<Post?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await dbContext.Set<Post>().FindAsync(id, cancellationToken);
    }
}
