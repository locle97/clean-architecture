using System.Linq.Expressions;

namespace Duckeebs.Core.Commons
{
  public interface IRepository<T> where T : class {
      // Get entity by id
      Task<T> GetByIdAsync(int id);

      // Get entity by filter
      Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> filter);

      // Get all entities
      Task<IEnumerable<T>> GetAllAsync();
      
      // Get entities with filter
      Task<IEnumerable<T>> GetByFilterAsync(Expression<Func<T, bool>> filter);

      // Add entity
      Task AddAsync(T entity);

      // Update entity
      Task UpdateAsync(T entity);

      // Delete entity
      Task DeleteAsync(int id);
  }
}
