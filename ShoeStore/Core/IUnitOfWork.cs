using System.Threading.Tasks;
using ShoeStore.Core;

namespace RealEstate.Core
{
    public interface IUnitOfWork
    {
        IHouseRepository Houses { get; }
        ICountyRepository Counties { get; }
        IPhotoRepository Photos { get; }
        Task CompleteAsync();
    }
}