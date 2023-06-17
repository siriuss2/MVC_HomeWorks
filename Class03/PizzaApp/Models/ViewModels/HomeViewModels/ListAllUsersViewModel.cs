using PizzaApp.Models.Domain;

namespace PizzaApp.Models.ViewModels.HomeViewModels
{
    public class ListAllUsersViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; }
    }
}
