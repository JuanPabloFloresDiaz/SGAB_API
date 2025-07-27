using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGAB_API.Entities
{
    [Table("tarifas_vuelo")]
    public class TarifaVuelo : BaseEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get => UUID; set => UUID = value; }

        [Required]
        [Column("vuelo_id")]
        public Guid VueloId { get; set; }
        public Vuelo? Vuelo { get; set; }

        [Required]
        [Column("clase_asiento")]
        public ClaseAsiento ClaseAsiento { get; set; }

        [Required]
        [Column("precio_base")]
        public decimal PrecioBase { get; set; }

        [Required]
        [Column("impuestos")]
        public decimal Impuestos { get; set; } = 0.00m;

        [Required]
        [Column("recargos")]
        public decimal Recargos { get; set; } = 0.00m;

        [Column("fecha_inicio_validez")]
        public DateTime? FechaInicioValidez { get; set; }

        [Column("fecha_fin_validez")]
        public DateTime? FechaFinValidez { get; set; }

        [Required]
        [Column("is_enabled")]
        public bool IsEnabled { get; set; } = true;
    }
}
