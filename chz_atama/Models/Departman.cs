using System.ComponentModel.DataAnnotations;

namespace chz_atama.Models
{
    public class Departman

    {

        [Key]
        public int DepartmanID { get; set; }
        public string? DepartmanAdi { get; set; } = string.Empty;

        public virtual List<Personel>? Personels { get; set; }
    }
}
