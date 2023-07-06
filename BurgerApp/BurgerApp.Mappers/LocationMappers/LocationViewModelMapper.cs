using BurgerApp.Domain.Models;
using BurgerApp.ViewModels.LocationViewModels;

namespace BurgerApp.Mappers.LocationMappers
{
    public static class LocationViewModelMapper
    {
        public static LocationViewModel ToLocationViewModel(this Location location)
        {
            return new LocationViewModel
            {
                Name = location.Name,
                Address = location.Address
            };
        }
    }
}
