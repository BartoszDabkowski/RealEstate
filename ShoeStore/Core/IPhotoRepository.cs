using System.Collections.Generic;
using System.Threading.Tasks;
using RealEstate.Core.Models;

namespace RealEstate.Core
{
    public interface IPhotoRepository
    {
        Task<IEnumerable<Photo>> GetPhotosAsync(int houseId);
    }
}