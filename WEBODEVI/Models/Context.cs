
using Microsoft.EntityFrameworkCore;

namespace WEBODEVI.Models
{
    public class Context:DbContext
    {
        public DbSet<Uye> Uyeler { get; set; }
        public DbSet<Araba> Arabalar { get; set; }

    }
}
