using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RealEstate.Core;
using RealEstate.Core.Models;

namespace RealEstate.Persistence
{
    public class CountyRepository : ICountyRepository
    {
        private readonly RealEstateDbContext _context;
        public CountyRepository(RealEstateDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<County>> GetCountiesAsync()
        {
            return await _context.Counties
                .Include(c => c.Cities)
                .ToListAsync();
        }

        public async Task<IEnumerable<City>> GetCitiesinCountyAsync(int countyId)
        {
            return await _context.Cities
                .Where(c => c.CountyId.Equals(countyId))
                .Include(c => c.County)
                .ToListAsync();
        }

        public async Task<IEnumerable<House>> GetHousesinCountyAsync(int countyId)
        {
            return  await _context.Houses
                .Join(_context.Cities,
                    h => h.Address.CityId,
                    c => c.Id,
                    (ho, ci) => new {ho, ci})
                .Where(join => join.ci.CountyId.Equals(countyId))
                .Select(houses => houses.ho)
                .Include(h => h.Photos)
                .ToListAsync();
        }

        public async Task<Location> GetCountyLocationAsync(int id)
        {
            var county = await _context.Counties
                .SingleOrDefaultAsync(c => c.Id.Equals(id));

            return new Location
            {
                Latitude = county.Latitude,
                Longitude = county.Longitude
            };
        }

        public async Task<Location> GetCityLocationAsync(int id)
        {
            var city = await _context.Cities
                .SingleOrDefaultAsync(c => c.Id.Equals(id));

            return new Location
            {
                Latitude = city.Latitude,
                Longitude = city.Longitude
            };
        }
    }
}