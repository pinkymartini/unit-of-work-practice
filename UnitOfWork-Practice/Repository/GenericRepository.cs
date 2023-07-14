using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UnitOfWork_Practice.Data;

namespace UnitOfWork_Practice.Repository
{
    public class GenericRepository : IGenericRepository
    {
        private readonly DatabaseContext databaseContext;   


        public GenericRepository(DatabaseContext databaseContext) {
        
            this.databaseContext = databaseContext;
        }

        public void Add<T>(T entity) where T : class
        {
            databaseContext.Set<T>().Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            databaseContext.Set<T>().Remove(entity);
        } 
        
        
        public void Update<T>(T entity) where T : class
        {
            databaseContext.Entry(entity).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
        }

        public async Task<IEnumerable<T>> FindAll<T>() where T : class
        {
            return await databaseContext.Set<T>().ToListAsync();
        }

        public async Task<T?> Find<T>(Expression<Func<T, bool>> expression) where T : class
        {
            return await databaseContext.Set<T>().Where(expression).FirstAsync();
        }
        

    }
}
