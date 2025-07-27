using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGAB_API.Entities
{
    [Table("aeropuertos")]
    public class Aeropuerto : BaseEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get => UUID; set => UUID = value; }

        [Required]
        [Column("nombre")]
        [MaxLength(255)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [Column("codigo_iata")]
        [MaxLength(3)]
        public string CodigoIATA { get; set; } = string.Empty;

        [Required]
        [Column("codigo_icao")]
        [MaxLength(4)]
        public string CodigoICAO { get; set; } = string.Empty;

        [Required]
        [Column("ciudad")]
        [MaxLength(100)]
        public string Ciudad { get; set; } = string.Empty;

        [Required]
        [Column("pais")]
        [MaxLength(100)]
        public string Pais { get; set; } = string.Empty;

        [Column("latitud")]
        public decimal? Latitud { get; set; }

        [Column("longitud")]
        public decimal? Longitud { get; set; }

        [Required]
        [Column("is_enabled")]
        public bool IsEnabled { get; set; } = true;
    }
}
