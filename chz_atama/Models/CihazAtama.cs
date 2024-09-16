using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chz_atama.Models
{
    public class CihazAtama
    {
        [Key]
        public int AtamaId { get; set; }
        public int? PersonelId { get; set; }
        public int? CihazId { get; set; }

        [ForeignKey("Departman")]
        public int? DepartmanID { get; set; }
        public DateTime? AtamaTarihi { get; set; }

        public virtual Cihaz? Cihaz { get; set; }
        public virtual Personel? Personel { get; set; }
        public virtual Departman? Departman { get; set; }
    }
}
