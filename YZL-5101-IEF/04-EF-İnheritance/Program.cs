using _04_EF_İnheritance.Context;
using _04_EF_İnheritance.Entites;
using System;


Console.WriteLine("Hello, World!");

// 3 Tane employee ekle
// 3 Tane customer ekle
AppDbContext appContext = new AppDbContext(); // tablolar ıle ılıskı kurmak ıcın veri tabanına ulasmak ıcın 
// AppDbContext appContext = new AppDbContext(); kullanılmasının sebebi daha once olusturulmus tabloya erişip o tobladan CRUD(Create,Read,Update,Delete) işlemleri yapmak ıcın kullanırım
appContext.Employees.Add(new Employee() { Name = "Ali", BirtDate = new DateTime(2500, 3, 10), JobDescription = "IT", AdmissionDate = new DateTime(2024, 5, 4) });
// appContext.Employees.Add employee koleksıyonuna yada tablosuna yeni bir employee ekler
appContext.Customers.Add(new Customer() { Name="Said",BirtDate = new DateTime(2005,03,09),LastPurchaseDate = new DateTime(2024,9,19),TotalVisit = 3000}); // customers koleksıyonuna yeni bir customer ekler



Employee employee = new Employee() { Name = "Ali", BirtDate = new DateTime(2000, 5, 6), JobDescription = "IT", AdmissionDate = new DateTime(2024, 4, 5) };
appContext.Employees.Add(new Employee() { Name = "Değişik Şeyler"});
Customer customer = new Customer() { Name = "Teknosa", LastPurchaseDate = DateTime.Now.AddDays(-10), TotalVisit = 100 };

appContext.basePeople.Add(customer);
appContext.Employees.Add(employee);
appContext.Employees.Add(employee);
appContext.SaveChanges();

// AppDbContext appContext = new AppDbContext(); veri tabanına erişip yeni şeyler eklememizi sağlar 


AppDbContext appContext1 = new AppDbContext(); //  veri tabanındakı onceden eklenmes toblolara erısım saglayıp onlar uzerınde ıslem yapabılırım
appContext1.Employees.Add(new Employee() { Name ="Bu Name Propu BasePersondan Geldı Mıras Aldıgım Icın Kullanabıldım",BirtDate = new DateTime(2343,32,34),JobDescription = new string("oyle yanı boyle de kullanılır herhalde arastırmak lazım ama string sınıf oldugu ıcın uretebıldım ")});