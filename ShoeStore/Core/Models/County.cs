using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Core.Models
{
    public class County
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public IEnumerable<City> Cities { get; set; }

        public County()
        {
            Cities = new Collection<City>();
        }
    }
}
