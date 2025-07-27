using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGAB_API.Entities
{
    [Table("tripulacion_vuelo")]
    public class TripulacionVuelo : BaseEntity
    {
        [Key]
        [Column("id")]
        public Guid Id { get => UUID; set => UUID = value; }

        [Required]
        [Column("vuelo_id")]
        public Guid VueloId { get; set; }
        public Vuelo? Vuelo { get; set; }

        [Required]
        [Column("personal_id")]
        public Guid PersonalId { get; set; }
        public Personal? Personal { get; set; }

        [Column("rol_en_vuelo")]
        [MaxLength(50)]
        public string? RolEnVuelo { get; set; }
    }
}
