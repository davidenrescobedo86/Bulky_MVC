using System.Linq.Expressions;

namespace BulkyWeb.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        //T - Category
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter=null, string? includeProperties = null); //get all
        T Get(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false); //get individual
        void Add(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);
    }
}
