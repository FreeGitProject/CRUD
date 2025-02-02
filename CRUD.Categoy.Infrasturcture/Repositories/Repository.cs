using CRUD.Category.Domain.Abstractions;
using Dapper;
using System.Data;
using Microsoft.EntityFrameworkCore;
using CRUD.Category.Infrastructure;

namespace CRUD.Categoy.Infrasturcture.Repositories;

internal abstract class Repository<T>
    where T : Entity
{
    protected readonly ApplicationDbContext DbContext;

    protected Repository(ApplicationDbContext dbContext)
    {
        DbContext = dbContext;
    }

    public async Task<T?> GetByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        return await DbContext
            .Set<T>()
            .FirstOrDefaultAsync(category => category.Id == id, cancellationToken);
    }

    public virtual void AddAsync(T entity)
    {
        DbContext.Add(entity);
    }
}