using System.Linq.Expressions;

namespace BarberShopp.Reference_Interfaces
{
    public interface IGenericRepository<T>
    {
        Task<List<T>> GetAll(Expression<Func<T, bool>> predicate, int skip, int? take);
        Task<T> Get(Expression<Func<T, bool>> predicate);
        void Insert(T obj);
        Task Update(T obj);
        Task Delete(T obj);
    }
}
