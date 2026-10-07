using Microsoft.EntityFrameworkCore;
using ToDo.Models;

namespace ToDo.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Persons> Persons { get; set; }
        public DbSet<ToDoo> ToDo { get; set; }
    }
}
