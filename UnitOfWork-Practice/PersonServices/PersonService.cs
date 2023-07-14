using Microsoft.AspNetCore.Mvc;
using UnitOfWork_Practice.Model;
using UnitOfWork_Practice.UnitOfWork;

namespace UnitOfWork_Practice.PersonServices
{
    public class PersonService : IPersonService
    {
        private readonly IUnitOfWorkFactory unitOfWorkFactory;


        public PersonService(IUnitOfWorkFactory unitOfWorkFactory ) { 
        
            this.unitOfWorkFactory = unitOfWorkFactory;

        }


        public async Task<List<Person>> GetPeople()
        {
            var unitOfWork = unitOfWorkFactory.CreateUnitOfWork();

            var people =  await unitOfWork.Repository().FindAll<Person>();

            return (List<Person>)people;
        }

        public async Task <Person> GetSinglePerson( int id)
        {

            var unitOfWork = unitOfWorkFactory.CreateUnitOfWork();
            var person = await unitOfWork.Repository().Find<Person>(x=> x.Id==id);
            return person;
        }
    }
}
