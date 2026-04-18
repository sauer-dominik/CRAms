using CRAms.Data.Models;
using System.Linq.Expressions;

namespace CRAms.Data.Interfaces
{
    public interface IEntityRepository<TEntity> where TEntity : Entity
    {
        Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task<int> CountAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default);
        Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default);
        Task<TEntity?> FindAsync(Guid id, CancellationToken cancellationToken = default);
        Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default);
        Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default);
        Task<IReadOnlyList<TEntity>> ToListAsync(CancellationToken cancellationToken = default);
        Task<IReadOnlyList<TEntity>> ToListAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default);
        Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
    }
}
