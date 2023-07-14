using System.Linq.Expressions;

namespace UnitOfWork_Practice.Repository
{
    public interface IGenericRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        //Task<IEnumerable<T>> Find<T>(T entity) where T : class;

        Task  <IEnumerable<T>> FindAll<T>() where T : class;
        Task<T> Find<T>(Expression<Func<T, bool>> expression) where T : class;
    }
}
