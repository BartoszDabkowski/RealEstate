using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ShoeStore.Core.Models
{
    public class Brand
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<Shoe> Shoes { get; set; }

        public Brand()
        {
            Shoes = new Collection<Shoe>();
        }
    }
}