using _03_EF_CodeFirst;
using static System.Reflection.Metadata.BlobBuilder;

Console.WriteLine();
/*
 
1- Entity'leri yazarım 
2- Entity'ler arasındaki ilişkileri kurarım.
3- Microsoft.EntityFramework; Nuget PAckage Manager'dan bu doysa yüklenir
4- AppDbContext isminde bir sınıf oluşturup. DbContext sınıfından miras alıyorum.
5- AppDbContext sınıfında Ovveride OnConfiguring metodunu ovveride ediyoruz ve içine 

 optionsBuilder.UseSqlServer
("Server=.;Database=CodeFirst1;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");

6- UseSqlServer metodunu kullanabilmek için NPM'den Microsoft.EntityFrameworkCore.SqlServer indiriyoruz.
7- PMC (Package Manager Console) aç. Default Project benim migration yapmak istediğim proje ile aynı olacak 
8- PMC:Nuget/Install-Package Microsoft.EntityFrameworkCore.Tools-Version 8.0.10
9- CTRL + Shift + B ile solution içindeki Error'ler varsa düzeltilecek.
10- PMC: PM> "add-migration ilk" yazıyoruz;
 11- PM
NuGet\Install-Package Microsoft.EntityFrameworkCore -Version 8.0.10
NuGet\Install-Package Microsoft.EntityFrameworkCore.SQLServer -Version 8.0.10 (Bunlar Yüklenecek)
NuGet\Install-Package Microsoft.EntityFrameworkCore.Tools -Version 8.0.10
 
 */


AppDbContext context = new AppDbContext(); //  AppDbContext deki olusturulmus tablolara ulaşmak için nesneini ürettim

List<Author> liste = context.Authors.ToList(); // Author sınıfından yenı  bır nensne ve tanımlı Author tablosunu lısteler

foreach (var item in liste)
{
    Console.WriteLine($"{item.Id}\t{item.Name}\t{item.Surname}");

}

// Insert yapıyoruz.
//context.Authors.Add(new Author() { Id = 3, Name = "Batuhan", Surname = "Balta" });

//context.SaveChanges(); // SaveChanges yaptığımızda context te yaptığımız tüm değişiklikler veritabanına kaydedilir.



//foreach (var item in liste)
//{
//    Console.WriteLine($"{item.Id}\t{item.Name}\t{item.Surname}");

//}

#region Update

//Author? author = context.Authors.Find(1); // İd değeri 1 olanı bulur yoksa null döner
//author? author = context.authors.find(6);
// syetem.nullreferenceexception:'object reference not set to an istance of an object.'
//if (author is not null)
//{
//    author.Name = "ege";
//    author.Surname = "gacal";


//}
//context.SaveChanges(); // insert,update,delete işlemlerden sonra çalıştırmamız gerekiyor. çoklu işlem yapıyorsam sadece 1 defa en sonra yazarız.

#endregion


#region Silme - Delete
// silinecek entity bul
// remove et
// savechanges();

//Author? author = context.Authors.Find(1);
//context.Authors.Remove(author);

//context.SaveChanges();
//foreach (var item in context.Authors.ToList())
//{
//    Console.WriteLine($"{item.Id}\t{item.Name}\t{item.Surname}");

//}
#endregion

#region 1-1 insert

//Author author1 = new Author()
//{

//    Name = "Eda",
//    Surname = "Aydın",
//    Profile = new Profile()
//    {
//        Email = "edaaydın@gmail.com",
//        DogumTarihi = new DateTime( 2000 , 5, 4)
//    }

//};

//context.Authors.Add(author1);

//context.SaveChanges();
#endregion

#region 1-N insert

// author ve book 

context.Authors.Add(new Author()
{
    Name = "said",
    Surname = "eruslu",
    Profile = new Profile()
    {
        Email = "saideruslu0@gmail.com",
        DogumTarihi = new DateTime(2005, 03, 09)
    },
    Books = new List<Book>()
    {
        new Book() {Title = "hoş geldin sincap bebek",PageSize = 20},
        new Book() {Title = "sincap bebek okulada başladı",PageSize = 25}
    },
}
);
context.SaveChanges(); // veritabanında değişiklikleri kalıcı yapmak ıcın bunu kullanıyorum  bunu ekledıgım zaman ramde olur ram olanı database'ye atıyorum

#endregion
// System.NullReferenceExcptiıon: 'Object referanca not set to an Instance of an object'

foreach (var author in context.Authors.ToList())
{
    Console.WriteLine($"{author.Id} {author.Name} {author.Surname} {author.Profile?.Email?? "Boş"}");

    if (author.Books is not null)
    {
        foreach (var book in author.Books)
        {
            Console.WriteLine($"\t{book.Title}\t{book.PageSize}");
        }
    }
}
// Lazy Loading
var BookWithAuthr = context.Books.Join(

   context.Authors,
   b => b.AuthorId,
   a => a.Id,
   (b, a) => new { Title = b.Title, PageSize = b.PageSize, FirstName = a.Name }
   ).ToList();

foreach (var item in BookWithAuthr)
{
    Console.WriteLine($"Kitap Adı {item.Title} Sayfa Sayısı {item.PageSize} Yazar Adı: {item.FirstName}");
}