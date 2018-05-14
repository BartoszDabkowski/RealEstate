using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ShoeStore.Controllers.Resources
{
    public class BrandResource
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public ICollection<BaseShoeResource> Shoes { get; set; }

        public BrandResource()
        {
            Shoes = new Collection<BaseShoeResource>();
        }
    }
}