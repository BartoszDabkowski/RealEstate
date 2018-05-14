using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using RealEstate.Core.Models;
using ShoeStore.Core.Models;

namespace ShoeStore.Controllers.Resources
{
    public class HouseResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HouseTypeId { get; set; }
        public HouseType HouseType { get; set; }
        public decimal Price { get; set; }
        public Address Address { get; set; }
        public decimal Longitude { get; set; }
        public decimal Latitude { get; set; }
        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int SquareFootage { get; set; }
        public double Acres { get; set; }
        public bool HasWaterfront { get; set; }
        public bool HasView { get; set; }
        public string Description { get; set; }
        public ICollection<PhotoResource> Photos { get; set; }

        public HouseResource()
        {
            Photos = new Collection<PhotoResource>();
        }
    }
}
