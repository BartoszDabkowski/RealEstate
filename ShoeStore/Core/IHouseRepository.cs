using System.Collections.Generic;
using System.Threading.Tasks;
using RealEstate.Core.Models;
using ShoeStore.Core.Models;

namespace ShoeStore.Core
{
    public interface IHouseRepository
    {
        Task<QueryResult<House>> GetHousesAsync(HouseQuery queryObj);
        Task<IEnumerable<House>> GetHousesAsync();
        Task<IEnumerable<House>> GetHousesInCityAsync(int cityId);
        Task<IEnumerable<HouseType>> GetHouseTypesAsync();
    }
}