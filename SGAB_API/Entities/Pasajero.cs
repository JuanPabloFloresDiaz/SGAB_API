using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGAB_API.Entities
{
    public enum Genero
    {
        M,
        F,
        Otro
    }

    [Table("pasajeros")]
    public class Pasajero : BaseEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get => UUID; set => UUID = value; }

        [Required]
        [Column("nombre")]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [Required]
        [Column("apellido")]
        [MaxLength(100)]
        public string Apellido { get; set; } = string.Empty;

        [Column("fecha_nacimiento")]
        public DateTime? FechaNacimiento { get; set; }

        [Column("genero")]
        public Genero? Genero { get; set; }

        [Column("nacionalidad")]
        [MaxLength(50)]
        public string? Nacionalidad { get; set; }

        [Column("numero_pasaporte")]
        [MaxLength(50)]
        public string? NumeroPasaporte { get; set; }

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
