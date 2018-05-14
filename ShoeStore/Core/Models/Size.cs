using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ShoeStore.Core.Models
{
    public class Size
    {
        public int Id { get; set; }
        [Required]
        [Range(6, 16)]
        public double Name { get; set; }
        public ICollection<Inventory> Inventory { get; set; }

        public Size()
        {
            Inventory = new Collection<Inventory>();
        }
    }
}