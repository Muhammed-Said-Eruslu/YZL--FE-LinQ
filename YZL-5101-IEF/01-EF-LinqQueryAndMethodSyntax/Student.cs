namespace _01_EF_LinqQueryAndMethodSyntax
{
    internal class Student
    {
        public int StudentId { get; set; } // kolumun ısmı Id dediğim zaman sql server otomatık olarak PK(Primary Key) olarak ayarlar
        public string Name { get; set; } // kolun ısmı
        public int Age { get; set; } // kolon ısmı
    }
}
