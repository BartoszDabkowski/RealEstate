using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ShoeStore.Core.Models
{
    public class Style
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public ICollection<ShoeStyle> ShoeStyles { get; set; }

        public Style()
        {
            ShoeStyles = new Collection<ShoeStyle>();
        }
    }
}