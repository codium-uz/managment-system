using System.Linq.Expressions;

namespace Managment.System.Infrastructure.Repositories;

public interface IRepository<TEntity>
{
    Task<IQueryable<TEntity>> SelectAllAsync(Expression<Func<TEntity, bool>> predicate = null, string[] includes = null, CancellationToken cancellation = default);
    Task<TEntity> SelectAsync(Expression<Func<TEntity, bool>> predicate, string[] includes = null, CancellationToken cancellation = default);
    Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellation = default);
    Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancelled = default);
    Task<bool> DeleteAsync(long id, CancellationToken cancellation = default);
    Task<bool> ExistsAsync(long id, CancellationToken cancellation = default);
    Task<bool> SaveAsync(CancellationToken cancellation = default);
}
