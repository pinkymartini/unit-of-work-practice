using Microsoft.EntityFrameworkCore;
using UnitOfWork_Practice.Data;

namespace UnitOfWork_Practice.UnitOfWork
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        public IUnitOfWork CreateUnitOfWork()
        {
            var optionBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optionBuilder.UseSqlServer("server=BRCKARGE069\\SQLEXPRESS;database=ToDoLists;Trusted_Connection=True;Encrypt=False");
            //var context = new DatabaseContext(optionBuilder.Options);
            return new UnitOfWork(new DatabaseContext(optionBuilder.Options));
        }
    }
}
