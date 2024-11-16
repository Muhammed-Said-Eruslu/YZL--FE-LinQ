using Microsoft.EntityFrameworkCore;

namespace _03_EF_CodeFirst
{
    internal class AppDbContext : DbContext
    {
        // DbContext : Verilerle nesneler olarak etkilesim kurmaktan sorumlu olan birincil sııftır. Nuget package managerden indirmemiz gerekir. Elçi gibi düşünülebilir
        public DbSet<Author> Authors { get; set; } // tabloya ulasmak istersek burdan ulasırız.

        public DbSet<Profile> Profiles { get; set; } // tabloya ulasmak istersek burdan ulasırız.

        public DbSet<Book> Books { get; set; }

        // DbSEt : Bir sınıfı bir db'deki belirli bir tabloyla eslestirmek için kullanılır kısaca vt islemleine acılan ag settir.

        // sql server için nuget package manager (NPM) 
        // OnConfiguration, entity sql ile olan 
        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            //"Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;"

            //optionsBuilder.UseSqlServer("Server=.;Database=Yzl5101-CodeFirst1;User Id=zdorter;Password=1q2w3e4r5t6y;");

            optionsBuilder.UseSqlServer("Server=DESKTOP-9TTU5F0\\SQLEXPRESS;Database=CodeFirst1;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");

        }
    }
}
