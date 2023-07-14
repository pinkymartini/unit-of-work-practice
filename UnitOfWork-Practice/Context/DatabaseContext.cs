using Microsoft.EntityFrameworkCore;
using UnitOfWork_Practice.Model;

namespace UnitOfWork_Practice.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions <DatabaseContext> options): base(options) { 
        }

        public DbSet<Person> People { get; set; }
    }
}
