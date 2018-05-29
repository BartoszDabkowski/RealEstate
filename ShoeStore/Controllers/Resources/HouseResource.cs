using System.Collections.Generic;
using System.Collections.ObjectModel;
using RealEstate.Core.Models;

namespace RealEstate.Controllers.Resources
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
