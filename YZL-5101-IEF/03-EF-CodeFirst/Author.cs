namespace _03_EF_CodeFirst
{
    // Once sınıflar olusur Burda ilk basta vt olustururuz.
    // 
    public class Author // bu sınıf bır yazarı temsil eder
    {
        // Id, AuthotId dersek kendisi otomatik primary key (pk) ve Auto Increment (1,1)
        public int Id { get; set; } // yazarın ID'di
        public string Name { get; set; } // yazarın ismi
        public string Surname { get; set; } // yazarın soyısmı
        public Profile Profile { get; set; } // her yazarın bır profili olabılır her bir profil bir yazara ait olur
        public List<Book> Books { get; set; } // Book sınıfı bır kitabi temsil eder yazarın yazdıgı kıtabı ve her yazarın bırden fazla kıtabı olabılır ama her kıtabın bır yazarı vardır 
    }
}
// özet Author(Yazar) bir yazarın bır tane profıle olur bu bıre bır ılıskı demek ama bır yazarın birden fazla kitabi olabilir

// Bire-bir ilişki bir tablodakı kaydın yalnızca bir diğer tablodakı bir kayıtla ilişkili olduğu durumdur.Yani her iki tabloda da sadece bir tane eşlesen kayıt vardır 
// her yazarın bir tane profılı vardır ve her profılın bır yazarı vardır