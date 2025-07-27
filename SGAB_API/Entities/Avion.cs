using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGAB_API.Entities
{
    [Table("aviones")]
    public class Avion : BaseEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get => UUID; set => UUID = value; }

        [Required]
        [Column("aerolinea_id")]
        public Guid AerolineaId { get; set; }
        public Aerolinea? Aerolinea { get; set; }

        [Required]
        [Column("modelo")]
        [MaxLength(100)]
        public string Modelo { get; set; } = string.Empty;

        [Required]
        [Column("matricula")]
        [MaxLength(20)]
        public string Matricula { get; set; } = string.Empty;

        [Required]
        [Column("capacidad_pasajeros")]
        public int CapacidadPasajeros { get; set; }

        [Column("tipo_aeronave")]
        [MaxLength(50)]
        public string? TipoAeronave { get; set; }

        [Required]
        [Column("is_enabled")]
        public bool IsEnabled { get; set; } = true;
    }
}
