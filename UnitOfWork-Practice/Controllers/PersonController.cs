using Microsoft.AspNetCore.Mvc;
using UnitOfWork_Practice.PersonServices;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UnitOfWork_Practice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : Controller
    {

        private readonly IPersonService personService;

        public PersonController(IPersonService personService)
        {
            this.personService = personService;
        }


        // GET: api/<ValuesController>
        [HttpGet]
        public async Task <IActionResult> Get()
        {
            var people = await personService.GetPeople();
            return Ok(people);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetSinglePerson([FromRoute] int id)
        {
            var people = await personService.GetSinglePerson(id);
            return Ok(people);
        }


    }
}
