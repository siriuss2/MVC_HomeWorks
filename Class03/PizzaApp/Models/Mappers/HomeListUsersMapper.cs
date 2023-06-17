using PizzaApp.Models.Domain;
using PizzaApp.Models.ViewModels.HomeViewModels;

namespace PizzaApp.Models.Mappers
{
    public static class HomeListUsersMapper
    {
        public static ListAllUsersViewModel MapFromUserToListAllUsers(this User user)
        {
            return new ListAllUsersViewModel()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = $"{user.Address.Street} {user.Address.Number}",
                PhoneNumber = user.PhoneNumber
            };
        }
    }
}
