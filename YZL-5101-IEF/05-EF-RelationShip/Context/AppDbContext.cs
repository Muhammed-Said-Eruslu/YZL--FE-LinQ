using _05_EF_RelationShip.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_EF_RelationShip.Context
{
    public class AppDbContext:DbContext
    {
        public DbSet<Catogery> Catogeries { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder) // OnConfiguring veri tabanını yeniden yapılandırır
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-9TTU5F0\\SQLEXPRESS;Database=CodeFirst3;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) // veritabanı şemasını ozelleştirmek karar yapısı vermek ve tablolar arasında kı ılıskılerı kurmaya yarar
        {
            // One To Many
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Catogery) // HasOne bir Product Bir Katogoriye sahiptir
               .WithMany(p => p.Catogeries) // Bir Categori Birden Fazla Product'ta sahiptir
               .HasForeignKey(p => p.CatogeryRefId); // foreigin key baglantısı

            // One To One
            modelBuilder.Entity<Product>()
             .HasOne(p => p.Detail) // bir productun bir tane detaili olur
             .WithOne(p => p.Product) // bir detailsın bir productı olur 
             .HasForeignKey<ProductDetail>(p => p.ProductRefId); // yabancı anahtar eşleşmesi
        }
    }
}
