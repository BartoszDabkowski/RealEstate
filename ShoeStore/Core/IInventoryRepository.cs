using ShoeStore.Core.Models;

namespace ShoeStore.Core
{
    public interface IInventoryRepository
    {
        void Add(Inventory inventory);
    }
}