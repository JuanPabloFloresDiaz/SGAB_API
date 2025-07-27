using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGAB_API.Entities
{
    [Table("personal")]
    public class Personal : BaseEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get => UUID; set => UUID = value; }

        [Required]
        [Column("aerolinea_id")]
        public Guid AerolineaId { get; set; }
        public Aerolinea? Aerolinea { get; set; }

        [Required]
        [Column("nombre")]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [Column("apellido")]
        [MaxLength(100)]
        public string Apellido { get; set; } = string.Empty;

        [Required]
        [Column("cargo")]
        [MaxLength(100)]
        public string Cargo { get; set; } = string.Empty;

        [Required]
        [Column("numero_empleado")]
        [MaxLength(50)]
        public string NumeroEmpleado { get; set; } = string.Empty;

        [Column("fecha_contratacion")]
        public DateTime? FechaContratacion { get; set; }

        [Column("email")]
        [MaxLength(255)]
        public string? Email { get; set; }

        [Column("telefono")]
        [MaxLength(50)]
        public string? Telefono { get; set; }

        [Required]
        [Column("is_enabled")]
        public bool IsEnabled { get; set; } = true;
    }
}
