using _05_EF_RelationShip.Context;
using _05_EF_RelationShip.Entity;
using System.Linq.Expressions;

Console.WriteLine("Hello World");

string catogrtName = "Kırtasiye";
AppDbContext ctxx = new AppDbContext();
int catogeryId;
if(!ctxx.Catogeries.Any(c => c.Name == catogrtName))
{
    ctxx.Catogeries.Add(new Catogery() { Name = catogrtName });
}
catogeryId = ctxx.Catogeries.FirstOrDefault(c => c.Name == catogrtName).Id;


ctxx.Products.Add(new Product()
{
    Name = "Kalem",
    Date = DateTime.Now,
    Price = 100,
    Stock = 23,
    CatogeryRefId = catogeryId,
    Detail = new ProductDetail()
    {
        Color = "Mavi",
        Height = "20",
        Width = "2"

    }
   
});

// Kategorı ekle
// Product Eklerken Catogery Id'yı bulun ve ıd ıle ekleyın ProductDetail ile eklensın

//ctxx.Products.Add(new Product()
//{
   
//    Name = "Çanta",
//    Date = DateTime.Now,
//    Price = 50,
//    Stock =133,
//    Catogery = new Catogery() { Name = "Kırtasiye"},
//    Detail = new ProductDetail()
//    {
//        Color = "Siyah",
//        Height = "30",
//        Width = "20"
//    }
//});

ctxx.SaveChanges(); // yukarıda kı gıbı ekledıgım zaman savecahnge etmem lazım 