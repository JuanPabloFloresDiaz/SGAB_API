using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGAB_API.Entities
{
    public enum UbicacionAsiento
    {
        Ventana,
        Pasillo,
        Centro
    }

    [Table("asientos")]
    public class Asiento : BaseEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get => UUID; set => UUID = value; }

        [Required]
        [Column("avion_id")]
        public Guid AvionId { get; set; }
        public Avion? Avion { get; set; }

        [Required]
        [Column("numero_asiento")]
        [MaxLength(10)]
        public string NumeroAsiento { get; set; } = string.Empty;

        [Required]
        [Column("clase")]
        public ClaseAsiento Clase { get; set; }

        [Column("ubicacion")]
        public UbicacionAsiento? Ubicacion { get; set; }

        [Required]
        [Column("is_enabled")]
        public bool IsEnabled { get; set; } = true;
    }
}
