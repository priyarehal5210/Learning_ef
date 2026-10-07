using ToDo.Dto;

namespace ToDo.Services
{
    public interface IPerson
    {
        List<PersonDto> GetPersons();
    }
}
