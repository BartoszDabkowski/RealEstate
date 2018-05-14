using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ShoeStore.Controllers.Resources
{
    public class SaveShoeResource
    {
        [Required]
        public int BrandId { get; set; } 
        [Required]
        public string Name { get; set; }
        public ICollection<int> Styles { get; set; }
        public ICollection<int> Colors { get; set; }
        public ICollection<int> Sizes { get; set; }

        public SaveShoeResource()
        {
            Styles = new Collection<int>();
            Colors = new Collection<int>();
            Sizes = new Collection<int>();
        }
    }
}