using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chz_atama.Models
{
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }
        public string? PersonelAd { get; set; } = string.Empty;
        public string? PersonelSoyad { get; set; } = string.Empty;

        [ForeignKey("Departman")]
        public int? DepartmanID { get; set; }
        public string? PersonelEposta { get; set; } = string.Empty;
        public string? PersonelTel { get; set; } = string.Empty;
        public string? FotoğrafYolu { get; set; } = string.Empty;

        public virtual Departman? Departman { get; set; }
        public virtual ICollection<CihazAtama> CihazAtamalar { get; set; }
    }
}
