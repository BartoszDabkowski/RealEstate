using System.Collections.Generic;
using System.Collections.ObjectModel;
using RealEstate.Core.Models;

namespace ShoeStore.Controllers.Resources
{
    public class CountyResource
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public ICollection<KeyValuePairResource> Cities { get; set; }

        public CountyResource()
        {
            Cities = new Collection<KeyValuePairResource>();
        }
    }
}