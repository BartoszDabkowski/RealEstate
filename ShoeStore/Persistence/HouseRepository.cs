using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RealEstate.Core;
using RealEstate.Core.Models;
using RealEstate.Extensions;

namespace RealEstate.Persistence
{
    public class HouseRepository : IHouseRepository
    {
        private readonly RealEstateDbContext _context;
        public HouseRepository(RealEstateDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<House>> GetHousesAsync()
        {
            return await _context.Houses
                .Include(h => h.Photos)
                .ToListAsync();
        }

        public async Task<House> GetHouseAsync(int id)
        {
            return await _context.Houses
                .Include(h => h.Photos)
                .SingleOrDefaultAsync(h => h.Id.Equals(id));
        }

        public async Task<QueryResult<House>> GetHousesAsync(HouseQuery queryObj)
        {
            var result = new QueryResult<House>();

            var query = _context.Houses
                .Include(h => h.Photos)
                .Include(h => h.Address.City)
                .AsQueryable();

            query = query.ApplyFiltering(queryObj);

            var columnsMap = new Dictionary<string, Expression<Func<House, object>>>()
            {
                ["price"] = h => h.Price
            };

            query = query.ApplyOrdering(queryObj, columnsMap);

            result.TotalItems = await query.CountAsync();

            query = query.ApplyPaging(queryObj);

            result.Items = await query.ToListAsync();

            return result;
        }

        public async Task<IEnumerable<House>> GetHousesInCityAsync(int cityId)
        {
            return await _context.Houses
                .Where(h => h.Address.CityId.Equals(cityId))
                .Include(h => h.Photos)
                .ToListAsync();
        }

        public async Task<IEnumerable<HouseType>> GetHouseTypesAsync()
        {
            return await _context.HouseType
                .ToListAsync();
        }
    }
}