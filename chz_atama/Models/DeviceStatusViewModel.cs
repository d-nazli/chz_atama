using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace chz_atama.Models
{
    public class DeviceStatusViewModel
    {
        [Key]
        public int Id { get; set; }
       
        public string Durum { get; set; } = string.Empty;
        [ForeignKey("CihazId")]
        public int CihazId { get; set; }
        public  Cihaz Cihaz { get; set; }
    }

}
