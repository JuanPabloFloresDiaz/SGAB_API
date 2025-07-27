using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGAB_API.Entities
{
    [Table("historial_mantenimiento")]
    public class HistorialMantenimiento : BaseEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get => UUID; set => UUID = value; }

        [Required]
        [Column("avion_id")]
        public Guid AvionId { get; set; }
        public Avion? Avion { get; set; }

        [Required]
        [Column("fecha_mantenimiento")]
        public DateTime FechaMantenimiento { get; set; }

        [Required]
        [Column("tipo_mantenimiento")]
        [MaxLength(100)]
        public string TipoMantenimiento { get; set; } = string.Empty;

        [Column("descripcion")]
        public string? Descripcion { get; set; }

        [Column("proximo_mantenimiento_fecha")]
        public DateTime? ProximoMantenimientoFecha { get; set; }

        [Column("costo")]
        public decimal? Costo { get; set; }

        [Column("realizado_por")]
        [MaxLength(255)]
        public string? RealizadoPor { get; set; }
    }
}
