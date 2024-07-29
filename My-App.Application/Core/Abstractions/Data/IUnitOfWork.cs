using Microsoft.EntityFrameworkCore.Storage;

namespace My_App.Application.Core.Abstractions.Data;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

    Task<IDbContextTransaction> BeginTransaction(CancellationToken cancellationToken);
}
