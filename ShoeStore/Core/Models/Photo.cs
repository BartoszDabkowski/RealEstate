using System.ComponentModel.DataAnnotations;

namespace RealEstate.Core.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public int HouseId { get; set; }
        public House House { get; set; }

        [Required]
        [StringLength(255)]
        public string FileName { get; set; }
    }
}
