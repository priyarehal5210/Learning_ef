using Microsoft.AspNetCore.Mvc;
using ToDo.Dto;
using ToDo.Services;

namespace ToDo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        //private readonly IPerson _person;
        //public PersonController(IPerson person)
        //{
        //    _person = person;
        //}
        //[HttpGet]
        //public async Task<IActionResult> GetPerson()
        //{
        //    List<PersonDto> response = _person.GetPersons();
        //    return Ok(response);
        //}
        [HttpGet("keyed")]
        public async Task<IActionResult> GetKeyedPerons([FromKeyedServices("persontest")] IPerson person)
        {
            List<PersonDto> response = person.GetPersons();
            return Ok(response);
        }
    }
}
