using _07_EF_LoadigType.Entities;
using Microsoft.EntityFrameworkCore; // Doğru DbContext sınıfını kullanıyoruz.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_EF_LoadigType.Context
{
    public class AppDbContext : DbContext
    {
        public DbSet<Catogery> Category { get; set; }
        public DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-9TTU5F0\\SQLEXPRESS;Database=Hastane4;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
