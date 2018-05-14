using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ShoeStore.Controllers.Resources
{
    public class ShoeResource
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public KeyValuePairResource Brand{ get; set; }
        public ICollection<KeyValuePairResource> Styles { get; set; }
        public ICollection<KeyValuePairResource> Colors { get; set; }
        public ICollection<KeyValuePairResource> Sizes { get; set; }

        public ShoeResource()
        {
            Styles = new Collection<KeyValuePairResource>();
            Colors = new Collection<KeyValuePairResource>();
            Sizes = new Collection<KeyValuePairResource>();
        }
    }
}