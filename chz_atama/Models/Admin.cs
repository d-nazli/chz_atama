using System.ComponentModel.DataAnnotations;

namespace chz_atama.Models
{
    
        public class Admin
        {
            [Key]
            public int AdminId { get; set; }

            [Required]
            [EmailAddress]
            public string AdminEposta { get; set; }

            [Required]
            public string Sifre { get; set; }  

            public string Yetki { get; set; }  
        }
    }

