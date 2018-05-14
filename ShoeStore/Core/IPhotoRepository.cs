using System.Collections.Generic;
using System.Threading.Tasks;
using ShoeStore.Core.Models;

namespace ShoeStore.Core
{
    public interface IPhotoRepository
    {
        Task<IEnumerable<Photo>> GetPhotosAsync(int houseId);
    }
}