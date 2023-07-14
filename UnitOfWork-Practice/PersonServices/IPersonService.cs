using Microsoft.AspNetCore.Mvc;
using UnitOfWork_Practice.Model;

namespace UnitOfWork_Practice.PersonServices
{
    public interface IPersonService
    {
        public Task<List<Person>> GetPeople();
        public Task<Person> GetSinglePerson( int id);
    }
}
