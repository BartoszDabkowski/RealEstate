using System.Collections.Generic;
using System.Threading.Tasks;
using ShoeStore.Core.Models;

namespace ShoeStore.Core
{
    public interface IShoeRepository
    {
        Task<QueryResult<Shoe>> GetShoesAsync(ShoeQuery queryObj);
        Task<Shoe> GetShoeAsync(int id, bool includeRelated = true);
        void Add(Shoe shoe);
    }
}