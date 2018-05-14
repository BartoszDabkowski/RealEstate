using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
    }
}
