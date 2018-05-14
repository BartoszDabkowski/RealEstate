using System.Collections.Generic;
using System.Threading.Tasks;
using ShoeStore.Core.Models;

namespace ShoeStore.Core
{
    public interface IStyleRepository
    {
         Task<IEnumerable<Style>> GetStylesAsync();
    }
}