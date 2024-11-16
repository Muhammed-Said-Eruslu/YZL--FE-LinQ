using _04_EF_İnheritance.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_EF_İnheritance.Context
{
    public class AppDbContext: DbContext // DbContext sınıfı veri tabanı ile baglantı kurmamızı sağlayan sınıfıtr
    {
        // 1.TPH (Table Per Hierarhy- Hiyerarşi başına tablo) tüm sınıf hiyerarşisini tek bir tabloya yerleştiren stratejidir tek tablo tum alt sınıfların ozellıklerını barındırır
        // bizim kullandıgmız TPT'dir her bir sınıf için ayrı bir tablo oluşturur
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<BasePerson> basePeople { get; set; }
        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder) // OnConfiguring veri tabanını yeniden yapılandırır
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-9TTU5F0\\SQLEXPRESS;Database=CodeFirst2;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }
    }
}


