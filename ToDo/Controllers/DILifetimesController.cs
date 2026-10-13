using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ToDo.Services;

namespace ToDo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DILifetimesController : ControllerBase
    {
        private readonly IPerson _person;
        private readonly IPerson _person1;
        public DILifetimesController(IPerson person, IPerson person1)
        {
            _person = person;
            _person1 = person1;
        }
        /// <summary>
        /// run below for transient and scoped lifetime
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetId")]
        public async Task<IActionResult> GetId()
        {
            Guid Id = await _person.GetId();
            int user = _person.AddUser();

            Guid id1 = await _person1.GetId();

            return Ok(new { Id, user, id1 });
        }
        [HttpGet("GetId1")]
        public async Task<IActionResult> GetId1()
        {
            Guid Id = await _person.GetId();
            return Ok(Id);
        }
    }
}
