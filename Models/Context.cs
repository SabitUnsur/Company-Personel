using Microsoft.EntityFrameworkCore;

namespace CompanyCore.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=EGEMEN\\SQLEXPRESS;database=CompanyCore;integrated security=true;TrustServerCertificate=True");
        }

        public DbSet<Unit> Units { get; set; } 
        public DbSet<Personel> Personels { get; set; }
        public DbSet<Admin> Admins { get; set; }



    }
}
