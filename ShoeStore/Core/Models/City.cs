using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealEstate.Core.Models
{
    public class City
    {
        public int Id { get; set; }
        public int CountyId { get; set; }
        public County County { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(9, 6)")]
        public decimal Longitude { get; set; }
        [Column(TypeName = "decimal(9, 6)")]
        public decimal Latitude { get; set; }
    }
}
