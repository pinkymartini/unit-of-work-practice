using UnitOfWork_Practice.Repository;

namespace UnitOfWork_Practice.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository Repository();
        Task Save();
        public void Dispose();
    }
}
