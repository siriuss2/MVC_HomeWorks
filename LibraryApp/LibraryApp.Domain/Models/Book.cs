using LibraryApp.Domain.Enums;

namespace LibraryApp.Domain.Models
{
    public class Book : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public Genre Genre { get; set; }
        public string ISBN { get; set; } = string.Empty;
        public DateTime PublicationDate { get; set; }
        public string Synopsis { get; set; } = string.Empty;
    }
}
