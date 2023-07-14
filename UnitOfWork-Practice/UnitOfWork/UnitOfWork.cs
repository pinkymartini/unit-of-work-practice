using UnitOfWork_Practice.Data;
using UnitOfWork_Practice.Repository;

namespace UnitOfWork_Practice.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext databaseContext;

        public UnitOfWork(DatabaseContext databaseContext) {
        
            this.databaseContext = databaseContext;
        }


        public void Dispose()
        {
            databaseContext.Dispose();
        }

        public IGenericRepository Repository()
        {
            return new GenericRepository(databaseContext); 
        }

        public Task Save()
        {
            return databaseContext.SaveChangesAsync();
        }
    }
}
