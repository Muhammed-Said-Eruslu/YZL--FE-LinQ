namespace _03_EF_CodeFirst
{
    public class Book
    {
        public int Id { get; set; } // Primary Key ve Identity(1,1)
        public string Title { get; set; } // nvarchar (max) Is Not Null
        public int? PageSize { get; set; } // ınt ıs null

        // Navigation 
        public int AuthorId { get; set; } // AuthorId sı olanın ID'sını getir yani bu kıtabın hangı yazara ait oldugunu belirtir 
        public Author Author { get; set; } // bu proptan author'a ulaşıyorum 
    }
}
