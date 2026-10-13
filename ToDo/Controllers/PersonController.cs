using Microsoft.AspNetCore.Mvc;
using ToDo.Dto;
using ToDo.Services;

namespace ToDo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPerson _person;
        private readonly IPerson _person1;
        public PersonController(IPerson person,IPerson person1)
        {
            _person = person;
            _person1 = person1;
        }
        //[HttpGet]
        //public async Task<IActionResult> GetPerson()
        //{
        //    List<PersonDto> response = _person.GetPersons();
        //    return Ok(response);
        //}
        //[HttpGet("keyed")]
        //public async Task<IActionResult> GetKeyedPerons([FromKeyedServices("persontest")] IPerson person)
        //{
        //    List<PersonDto> response = person.GetPersons();
        //    return Ok(response);
        //}
    }
}
