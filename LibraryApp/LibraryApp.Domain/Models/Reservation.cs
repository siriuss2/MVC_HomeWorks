using LibraryApp.Domain.Enums;

namespace LibraryApp.Domain.Models
{
    public class Reservation : BaseEntity
    {
        public int MemberID { get; set; }
        public string BookTitle { get; set; }
        public DateTime ReservationDate { get; set; }
        public ReservationStatusEnum ReservationStatus { get; set; }
    }
}
