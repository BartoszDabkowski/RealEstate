using System.Collections.Generic;
using System.Threading.Tasks;
using RealEstate.Core.Models;

namespace RealEstate.Core
{
    public interface ICountyRepository
    {
         Task<IEnumerable<County>> GetCountiesAsync();
         Task<IEnumerable<City>> GetCitiesinCountyAsync(int countyId);
         Task<IEnumerable<House>> GetHousesinCountyAsync(int countyId);
         Task<Location> GetCountyLocationAsync(int id);
         Task<Location> GetCityLocationAsync(int id);
    }
}