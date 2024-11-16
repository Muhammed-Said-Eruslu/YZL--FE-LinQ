using _07_EF_LoadigType.Context;
using _07_EF_LoadigType.Entities;
using Microsoft.EntityFrameworkCore;


using (var context = new AppDbContext())
{
    context.Category.Add( // Category tablosuna yeni bir Category ekler
        new Catogery()
        {
            Name = "Elektronik", // eklenecek olan kategorının ısmı 
            url = "",
            Products =  new List<Products>() // Products'ları tutacak olan lıste 
            {
                new Products()
                {
                    Name = "Laptop",
                    Price = 15000,
                    Stock = 55
                },
                new Products()
                {
                    Name = "Mouse",
                    Price = 1500,
                    Stock = 50
                },
                new Products()
                {
                    Name = "Klavye",
                    Price = 500,
                    Stock = 75
                }
            }
            
        });
    context.SaveChanges();
}
using(var context  = new AppDbContext())
{
    context.Category.Add(
        new Catogery()
        {
            Name = "Kırtasiye",
            url = "",
            Products = new List<Products>()
            {
               new Products()
               {
                   Name = "Kitap",
                   Price = 50,
                   Stock = 100
               },
               new Products()
               {
                   Name = "Silgi",
                   Price = 20,
                   Stock = 200
               },
               new Products()
               {
                   Name = "Kalem",
                   Price = 70,
                   Stock = 30
               }
            }
        });
}
using (var context = new AppDbContext())
{
    context.Products.Join( //Products tablosu ıle  Category tablosu arasındaa joın ıslemı yapıyor ilişkili kayıtları birleştirir
        context.Category,
        p => p.CatogeryId, // Products sınıfındakı CatogeryId ıle Category sınıfındakı ıd eşleşiyor boylece her bır urunun hangı katogeri ıd de oldugunu bulmamızı sağlar 
        c => c.Id, // Category sınıfındaki ıd ıle Products sınıfındakı ıd eşleşiyor boylece hangı urunun hangı katogoriye ait oldugu belırlenıyor
        (p, c) => new // yeni bir anonım tipi 
        {
            Name = p.Name, // ismi Ürününün adı
            Price = p.Price, // stogu urunun stogu
            Stok = p.Stock, // stogu urunun stogu 
            Category = c.Name // kategorının adı 
        }
        ).ToList(); // listeye donusturur
}
AppDbContext appDbContext = new AppDbContext();
var product3 = appDbContext.Products.ToList(); // lazy loadıng suan bırsey dahıl değil
appDbContext.Products.ToList().ForEach (p => Console.WriteLine(p.Name));
var product1 = appDbContext.Products.Include("Catogery"); // ürünün ait olduğu kategoriyi almamızı sağlar ılıskılı oldugu ıcın yani category ıd kısmınıda dahil eder
var product2 = appDbContext.Products.Include(p => p.Catogery); // Products tablosundakı Catogery ile ilişkilendirmiş tüm verileri getirir ama yazdırma ıslemı yapmaz (Eager Loading) Tüm verileri getirir
foreach (var products in product3)
{
    Console.WriteLine(products.Catogery.Name); // ve ihtiyac duyulduğundad getırır
}
appDbContext.Products.ToList().ForEach(p => Console.WriteLine(p.Catogery.Name)); // Products tablosunu lısteye çevirir Catogery ile eşleşmiş olan ısımlerı getirir (Lazy Loading)
/*
 
Eager Loading(ön yüklemeli): İlişkili verileri ana sorgu ile birlikte yüklemeyi amaçlar  ve ilişkili verileri bir kerede almak ıcın kullanılır  bellek kullanımını arttırabilir
Lazy Loading(tembel yükleme): ilişkili verileri yalnızca gerektiğinde almak için idealdir bellek kullanımını azaltır ancak cok sayıda sorguya neden olur 
yanı sık sık ılısklı verılere ulasıyorsam eager ama daha nadırse bu durum lazy

 */
/*
 Eager Loading: İlgili verilere tek seferde ulaşmamızı sağlar 
Lazy Loading: Sadece İhtiyaç duyulan verilere ulaşmamızı sağlar
 
 */