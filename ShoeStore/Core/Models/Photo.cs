using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using RealEstate.Core.Models;

namespace ShoeStore.Core.Models
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
