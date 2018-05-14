using System.Threading.Tasks;
using RealEstate.Core;
using ShoeStore.Core;

namespace ShoeStore.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RealEstateDbContext _context;
        private IHouseRepository _houses;
        private ICountyRepository _counties;
        private IPhotoRepository _photos;

        public IPhotoRepository Photos{get{
                return _photos = _photos ?? new PhotoRepository(_context);
        }}

        public IHouseRepository Houses{get{
                return _houses = _houses ?? new HouseRepository(_context);
        }}

        public ICountyRepository Counties{get{
                return _counties = _counties ?? new CountyRepository(_context);
        }}

        public UnitOfWork(RealEstateDbContext context)
        {
            _context = context;
        }
        
        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}