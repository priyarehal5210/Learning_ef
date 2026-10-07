using ToDo.Dto;

namespace ToDo.Services
{
    public class Persons : IPerson
    {
        public List<PersonDto> GetPersons()
        {
            return new List<PersonDto>
            {
                new PersonDto { Id = 1, Name = "John Doe" },
                new PersonDto { Id = 2, Name = "Jane Smith" },
                new PersonDto { Id = 3, Name = "Alice Johnson" }
            };
        }
    }
    public class PersonTest : IPerson
    {
        public List<PersonDto> GetPersons()
        {
            return new List<PersonDto>
            {
                new PersonDto { Id = 1, Name = "priya" },
            };
        }
    }
}
