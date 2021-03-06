using System.Linq.Expressions;
namespace DotNetCoreWebApiRepositoryPattern.Data
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task<T> Update(int id, T entity);
        Task<T> Delete(int id);
        Task Remove(T entity);
        void RemoveRange(IEnumerable<T> entities);

    }
}
