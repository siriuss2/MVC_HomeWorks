namespace LibraryApp.Domain.Models
{
    public class Author : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public List<Book> Bibliography { get; set; } = new List<Book>();
        public List<string> Awards { get; set; } = new List<string>();
        public string Biography { get; set; } = string.Empty;
    }
}
