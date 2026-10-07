namespace ToDo.Dto
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class ToDoDto
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
    }
}
