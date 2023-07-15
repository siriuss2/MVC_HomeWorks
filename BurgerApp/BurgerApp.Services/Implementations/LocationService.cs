using BurgerApp.DataAccess.Repositories.Interfaces;
using BurgerApp.Domain.Models;
using BurgerApp.Mappers.LocationMappers;
using BurgerApp.Services.Interfaces;
using BurgerApp.ViewModels.LocationViewModels;

namespace BurgerApp.Services.Implementations
{
    public class LocationService : ILocationService
    {
        private IRepository<Location> _locationRepository;

        public LocationService(IRepository<Location> _locationRepository)
        {
            this._locationRepository = _locationRepository;
        }
        public async Task<List<LocationsForDropdownViewModel>> GetLocationsForDropdown()
        {
            List<Location> locationDb = await _locationRepository.GetAll();
            return locationDb.Select(x => x.ToLocationsForDropdown()).ToList();
        }
    }
}
