using Microsoft.EntityFrameworkCore;

namespace My_App.Application.Core.Abstractions.Data;

public interface IDbContext
{
    DbSet<TEntity> Set<TEntity>() where TEntity : class;
}
