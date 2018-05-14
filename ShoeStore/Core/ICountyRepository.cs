using System.Collections.Generic;
using System.Threading.Tasks;
using RealEstate.Core.Models;
using ShoeStore.Core.Models;

namespace ShoeStore.Core
{
    public interface ICountyRepository
    {
         Task<IEnumerable<County>> GetCountiesAsync();
         Task<IEnumerable<City>> GetCitiesinCountyAsync(int countyId);
         Task<IEnumerable<House>> GetHousesinCountyAsync(int countyId);
    }
}