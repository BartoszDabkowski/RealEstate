using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RealEstate.Controllers.Resources
{
    public class CountyResource
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public ICollection<KeyValuePairResource> Cities { get; set; }

        public CountyResource()
        {
            Cities = new Collection<KeyValuePairResource>();
        }
    }
}