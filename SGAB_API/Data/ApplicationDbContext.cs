using Microsoft.EntityFrameworkCore;
using SGAB_API.Entities;

namespace SGAB_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Aerolinea> Aerolineas { get; set; }
        public DbSet<Aeropuerto> Aeropuertos { get; set; }
        public DbSet<Avion> Aviones { get; set; }
        public DbSet<Vuelo> Vuelos { get; set; }
        public DbSet<Pasajero> Pasajeros { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Asiento> Asientos { get; set; }
        public DbSet<Personal> Personal { get; set; }
        public DbSet<TripulacionVuelo> TripulacionVuelos { get; set; }
        public DbSet<HistorialMantenimiento> HistorialesMantenimiento { get; set; }
        public DbSet<TipoVuelo> TiposVuelo { get; set; }
        public DbSet<TarifaVuelo> TarifasVuelo { get; set; }
        public DbSet<Pago> Pagos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Puedes agregar configuraciones adicionales aquí si es necesario
        }
    }
}
