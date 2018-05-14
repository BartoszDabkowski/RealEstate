using System.Collections.Generic;
using System.Threading.Tasks;
using ShoeStore.Core.Models;

namespace ShoeStore.Core
{
    public interface IBrandRepository
    {
         Task<IEnumerable<Brand>> GetBrandsAsync();
    }
}