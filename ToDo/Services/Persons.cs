using ToDo.Dto;

namespace ToDo.Services
{
    public class Persons : IPerson
    {
        private readonly Guid _id = Guid.NewGuid();
        int totalcount = 0;

        public int AddUser()
        {
            totalcount++;
            return totalcount;
        }

        public async Task<Guid> GetId()
        {
            return _id;
        }

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
    //below class to understand keyed service
    //public class PersonTest : IPerson
    //{
    //    public List<PersonDto> GetPersons()
    //    {
    //        return new List<PersonDto>
    //        {
    //            new PersonDto { Id = 1, Name = "priya" },
    //        };
    //    }
    //}
}
