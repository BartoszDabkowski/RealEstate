using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Controllers.Resources
{
    public class AddressResource
    {
        public string Street { get; set; }
        public CityResource City { get; set; }
        public int ZipCode { get; set; }
    }
}
