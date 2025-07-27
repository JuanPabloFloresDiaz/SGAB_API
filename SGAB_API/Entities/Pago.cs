using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGAB_API.Entities
{
    public enum EstadoPago
    {
        Pendiente,
        Completado,
        Rechazado,
        Reembolsado
    }

    [Table("pagos")]
    public class Pago : BaseEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get => UUID; set => UUID = value; }

        [Required]
        [Column("reserva_id")]
        public Guid ReservaId { get; set; }
        public Reserva? Reserva { get; set; }

        [Required]
        [Column("monto")]
        public decimal Monto { get; set; }

        [Required]
        [Column("moneda")]
        [MaxLength(3)]
        public string Moneda { get; set; } = "USD";

        [Required]
        [Column("fecha_pago")]
        public DateTime FechaPago { get; set; } = DateTime.UtcNow;

        [Column("metodo_pago")]
        [MaxLength(50)]
        public string? MetodoPago { get; set; }

        [Required]
        [Column("estado_pago")]
        public EstadoPago EstadoPago { get; set; } = EstadoPago.Completado;

        [Column("transaccion_id_externa")]
        [MaxLength(100)]
        public string? TransaccionIdExterna { get; set; }
    }
}
