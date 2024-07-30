using Managment.System.DAL.Data.Contexts;
using Managment.System.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Managment.System.Infrastructure.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : AudiTable
{
    private AppDbContext dbContext;
    DbSet<TEntity> dbSet;
    public Repository(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
        dbSet = dbContext.Set<TEntity>();
    }
    public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellation = default)
        => (await dbSet.AddAsync(entity, cancellation).ConfigureAwait(false)).Entity;

    public async Task<bool> DeleteAsync(long id, CancellationToken cancellation = default)
    {
        var entity = await dbSet
            .FirstOrDefaultAsync(x => x.Id == id, cancellation)
            .ConfigureAwait(false);

        dbSet.Remove(entity);
        return true;
    }

    public async Task<bool> ExistsAsync(long id, CancellationToken cancellation = default)
        => await dbSet.AnyAsync(x => x.Id == id, cancellation);

    public async Task<bool> SaveAsync(CancellationToken cancellation = default)
        => await dbContext.SaveChangesAsync(cancellation).ConfigureAwait(false) > 0;

    public Task<IQueryable<TEntity>> SelectAllAsync(Expression<Func<TEntity, bool>> predicate = null, string[] includes = null, CancellationToken cancellation = default)
    {
        return Task.Run(async () =>
        {
            var query = predicate is null ? dbSet : dbSet.Where(predicate);

            if(includes is not null)
                foreach(var include in includes)
                    query = query.Include(include);

            return query;
        }, cancellation);
    }

    public async Task<TEntity> SelectAsync(Expression<Func<TEntity, bool>> predicate, string[] includes = null, CancellationToken cancellation = default)
    {
        var query = await SelectAllAsync(predicate, includes, cancellation).ConfigureAwait(false);
        return await query.FirstOrDefaultAsync(predicate, cancellation).ConfigureAwait(false);
    }

    public Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancelled = default)
        => Task.Run(() => dbSet.Update(entity).Entity, cancelled);
}
