using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Core.Models
{
    public class Address
    {
        public string Street { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int ZipCode { get; set; }
    }
}
