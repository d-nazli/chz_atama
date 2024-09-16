using chz_atama.Models;
using Microsoft.EntityFrameworkCore;

namespace chz_atama.Data
{
   
        public class ApplicationDbContext : DbContext
       
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
            {
            }
            public DbSet<Cihaz>Cihazs{ get; set; }
            public DbSet<CihazAtama> CihazAtamas{ get; set; }
            public DbSet<Departman> Departmans { get; set; }
            public  DbSet<Personel> Personels { get; set; }
            public DbSet<DeviceStatusViewModel> DeviceStatusViewModels { get; set; }
        public DbSet<Admin> Admins { get; set; }


    }
    
}
