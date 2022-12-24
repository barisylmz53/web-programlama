
using Microsoft.EntityFrameworkCore;

namespace WEBODEVI.Models
{
    public class Context:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-9991\\SQLEXPRESS;Database=CarDB;integrated security = true;");
        }
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Araba> Arabalar { get; set; }

    }
}
