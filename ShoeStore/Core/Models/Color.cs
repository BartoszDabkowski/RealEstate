using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ShoeStore.Core.Models
{
    public class Color
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<Inventory> Inventory { get; set; }

        public Color()
        {
            Inventory = new Collection<Inventory>();
        }
    }
}