namespace ToDo.Models
{
    public class ToDoo
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public Persons Person { get; set; }
    }
}
