using System.ComponentModel.DataAnnotations;

namespace chz_atama.Models
{
    public class Cihaz
    {
        [Key]
        public int CihazId { get; set; }
        public string? CihazAdi { get; set; } = string.Empty;
        public string? CihazModel { get; set; } = string.Empty;
        public string? CihazSeriNo { get; set; } = string.Empty;
        public bool IsAssigned { get; set; }
    }
}
