namespace _03_EF_CodeFirst
{
    // Primary Key: Unique (tekil,eşssiz)  // Id,Class,NameId
    // Identy (1,1)
    public class Profile
    {
        public int ProfileId { get; set; } // Primary Key
        public DateTime DogumTarihi { get; set; }
        public string Email { get; set; } 

        public int AuthorId { get; set; } // Foreign Key
        public Author Author { get; set; }
    }
}