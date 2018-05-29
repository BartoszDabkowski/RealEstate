using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RealEstate.Core;
using RealEstate.Core.Models;

namespace RealEstate.Persistence
{
    public class PhotoRepository : IPhotoRepository
    {
        private readonly RealEstateDbContext _context;
        public PhotoRepository(RealEstateDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Photo>> GetPhotosAsync(int houseId)
        {
            return await _context.Photo
                .Where(p => p.HouseId.Equals(houseId))
                .ToListAsync();
        }

    }
}