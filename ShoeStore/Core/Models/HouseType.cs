using System.ComponentModel.DataAnnotations;

namespace RealEstate.Core.Models
{
    public class HouseType
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
