using _06_EF_DataAnnotationFluentAPI.Entities;
using _06_EF_DataAnnotationFluentAPI.Mapping;
using Microsoft.EntityFrameworkCore;

namespace _06_EF_DataAnnotationFluentAPI.Context
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=GMSK-MDR-519TY1;Database=Yzl5101-CodeFirst4;User Id=zdorter;Password=1q2w3e4r5t6y;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }

        // Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Book>().HasKey(x => x.BookId); // PK

            //modelBuilder.Entity<Book>()
            //    .Property(b => b.Title)
            //    .IsRequired(true)
            //    .HasMaxLength(150);

            //modelBuilder.Entity<Book>()
            //    .ToTable("TblBook");

            //modelBuilder.Entity<Book>()
            //    .Property(b => b.Title)
            //    .HasColumnName("Description")
            //    .HasColumnOrder(2)
            //    .HasColumnType("nvarchar(150)");

            modelBuilder.ApplyConfiguration(new BookMapping());

            modelBuilder.ApplyConfiguration(new AuthorMapping());


            //modelBuilder.Entity<Author>()
            //    .Ignore(b => b.FullName);

            //Seed Data, veritabanı ilk oluştuğunda default değerler yüklemek için kullanılır.

            //modelBuilder.Entity<Author>()
            //    .HasData(
            //        new Author
            //        {
            //            AuthorId = 1,
            //            FirstName = "William",
            //            LastName = "Shakespeare"
            //        },
            //        new Author
            //        {
            //            AuthorId = 2,
            //            FirstName = "Fyodor",
            //            LastName = "Dostoyeski"
            //        },
            //        new Author
            //        {
            //            AuthorId = 3,
            //            FirstName = "Fatih",
            //            LastName = "Alkan"
            //        }
            //    );
        }
    }
}
