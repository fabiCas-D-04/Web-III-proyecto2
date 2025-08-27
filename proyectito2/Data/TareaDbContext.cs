using Microsoft.EntityFrameworkCore;
using proyectito2.Models;


namespace WARazorDB.Data
{
    public class TareaDbContext : DbContext
    {
        public TareaDbContext(DbContextOptions<TareaDbContext> options) : base(options)
        {
        }

        public DbSet<Tarea> Tareas { get; set; }
        protected TareaDbContext()
        {

        }
    }
}
