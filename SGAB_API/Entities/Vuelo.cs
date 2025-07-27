using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGAB_API.Entities
{
    public enum EstadoVuelo
    {
        Programado,
        En_Vuelo,
        Aterrizado,
        Retrasado,
        Cancelado
    }

    [Table("vuelos")]
    public class Vuelo : BaseEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get => UUID; set => UUID = value; }

        [Required]
        [Column("aerolinea_id")]
        public Guid AerolineaId { get; set; }
        public Aerolinea? Aerolinea { get; set; }

        [Required]
        [Column("avion_id")]
        public Guid AvionId { get; set; }
        public Avion? Avion { get; set; }

        [Required]
        [Column("numero_vuelo")]
        [MaxLength(20)]
        public string NumeroVuelo { get; set; } = string.Empty;

        [Required]
        [Column("origen_aeropuerto_id")]
        public Guid OrigenAeropuertoId { get; set; }
        public Aeropuerto? OrigenAeropuerto { get; set; }

        [Required]
        [Column("destino_aeropuerto_id")]
        public Guid DestinoAeropuertoId { get; set; }
        public Aeropuerto? DestinoAeropuerto { get; set; }

        [Required]
        [Column("fecha_salida")]
        public DateTime FechaSalida { get; set; }

        [Required]
        [Column("fecha_llegada_estimada")]
        public DateTime FechaLlegadaEstimada { get; set; }

        [Column("duracion_estimada_minutos")]
        public int? DuracionEstimadaMinutos { get; set; }

        [Required]
        [Column("estado_vuelo")]
        public EstadoVuelo EstadoVuelo { get; set; } = EstadoVuelo.Programado;

        [Column("tipo_vuelo_id")]
        public Guid? TipoVueloId { get; set; }
        public TipoVuelo? TipoVuelo { get; set; }

        [Required]
        [Column("is_enabled")]
        public bool IsEnabled { get; set; } = true;
    }
}
