using System.Collections.Generic;
using System.Threading.Tasks;
using ShoeStore.Core.Models;

namespace ShoeStore.Core
{
    public interface ISizeRepository
    {
        Task<IEnumerable<Size>> GetSizesAsync();
    }
}