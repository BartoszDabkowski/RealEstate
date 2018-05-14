using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ShoeStore.Core.Models;

namespace RealEstate.Core.Models
{
    public class House
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int HouseTypeId { get; set; }
        public HouseType HouseType { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public Address Address { get; set; }

        [Required]
        [Column(TypeName = "decimal(9, 6)")]
        public decimal Longitude { get; set; }

        [Required]
        [Column(TypeName = "decimal(9, 6)")]
        public decimal Latitude { get; set; }

        [Required]
        public int Bedrooms { get; set; }

        [Required]
        public int Bathrooms { get; set; }

        [Required]
        public int SquareFootage { get; set; }

        [Required]
        public double Acres { get; set; }

        [Required]
        public bool HasWaterfront { get; set; }

        [Required]
        public bool HasView { get; set; }

        [Required]
        public string Description { get; set; }

        public ICollection<Photo> Photos { get; set; }

    }
}
