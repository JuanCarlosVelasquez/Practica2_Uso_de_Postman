using apiUsers.Modelos;
using Microsoft.EntityFrameworkCore;

namespace apiUsers.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //Agregar los modelos aquí
        public DbSet<User> User { get; set; }
    }
}
