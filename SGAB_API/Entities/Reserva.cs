using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGAB_API.Entities
{
    public enum ClaseAsiento
    {
        Economica,
        Premium_Economica,
        Ejecutiva,
        Primera
    }

    public enum EstadoReserva
    {
        Confirmada,
        Pendiente,
        Cancelada,
        Completada
    }

    [Table("reservas")]
    public class Reserva : BaseEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get => UUID; set => UUID = value; }

        [Required]
        [Column("vuelo_id")]
        public Guid VueloId { get; set; }
        public Vuelo? Vuelo { get; set; }

        [Required]
        [Column("pasajero_id")]
        public Guid PasajeroId { get; set; }
        public Pasajero? Pasajero { get; set; }

        [Required]
        [Column("codigo_reserva")]
        [MaxLength(20)]
        public string CodigoReserva { get; set; } = string.Empty;

        [Required]
        [Column("fecha_reserva")]
        public DateTime FechaReserva { get; set; } = DateTime.UtcNow;

        [Required]
        [Column("clase_asiento")]
        public ClaseAsiento ClaseAsiento { get; set; }

        [Column("numero_asiento")]
        [MaxLength(10)]
        public string? NumeroAsiento { get; set; }

        [Required]
        [Column("precio_pagado")]
        public decimal PrecioPagado { get; set; }

        [Required]
        [Column("estado_reserva")]
        public EstadoReserva EstadoReserva { get; set; } = EstadoReserva.Confirmada;

        [Required]
        [Column("is_enabled")]
        public bool IsEnabled { get; set; } = true;
    }
}
