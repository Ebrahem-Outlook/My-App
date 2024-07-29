using Microsoft.EntityFrameworkCore;
using My_App.Domain.Core.TypeBase;

namespace My_App.Application.Core.Abstractions.Data;

public interface IDbContext
{
    DbSet<TEntity> Set<TEntity>() where TEntity : Entity;
}
