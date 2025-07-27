using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGAB_API.Entities
{
    [Table("aerolineas")]
    public class Aerolinea : BaseEntity
    {
        [Key]
        [Column("id")]
        public Guid Id
        {
            get => UUID;
            set => UUID = value;
        }

        [Required]
        [Column("nombre")]
        [MaxLength(100)]
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
        [Column("is_enabled")]
        public bool IsEnabled { get; set; } = true;
    }
}
