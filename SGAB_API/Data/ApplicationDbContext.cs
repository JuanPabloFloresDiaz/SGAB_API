using Microsoft.EntityFrameworkCore;
using SGAB_API.Entities;

namespace SGAB_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Aerolinea> Aerolineas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Puedes agregar configuraciones adicionales aquí si es necesario
        }
    }
}
