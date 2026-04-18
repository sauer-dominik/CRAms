using CRAms.Data.Interfaces;
using CRAms.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CRAms.Data.Repositories
{
    public class EntityRepository<TEntity> : IEntityRepository<TEntity> where TEntity : Entity
    {
        private readonly CRAmsDbContext dbContext;

        public EntityRepository(CRAmsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            await dbContext.Set<TEntity>().AddAsync(entity, cancellationToken);
            await dbContext.SaveChangesAsync(cancellationToken);

            return entity;
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default)
        {
            return await dbContext.Set<TEntity>().CountAsync(expression, cancellationToken);
        }

        public async Task DeleteAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            dbContext.Set<TEntity>().Remove(entity);
            await dbContext.SaveChangesAsync(cancellationToken);
        }

        public virtual async Task<TEntity?> FindAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await dbContext.Set<TEntity>().FindAsync([id], cancellationToken);
        }

        public virtual async Task<TEntity> FirstAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default)
        {
            return await dbContext.Set<TEntity>().FirstAsync(expression, cancellationToken);
        }

        public virtual async Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default)
        {
            return await dbContext.Set<TEntity>().FirstOrDefaultAsync(expression, cancellationToken);
        }

        public virtual async Task<IReadOnlyList<TEntity>> ToListAsync(CancellationToken cancellationToken = default)
        {
            return await dbContext.Set<TEntity>().ToListAsync(cancellationToken);
        }

        public virtual async Task<IReadOnlyList<TEntity>> ToListAsync(Expression<Func<TEntity, bool>> expression, CancellationToken cancellationToken = default)
        {
            return await dbContext.Set<TEntity>().Where(expression).ToListAsync(cancellationToken);
        }

        public async Task UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            await dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}
