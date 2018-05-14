using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ShoeStore.Core.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public int ShoeId { get; set; }
        public Shoe Shoe { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public int SizeId { get; set; }
        public Size Size { get; set; }
        public bool IsDeleted {get; set;}
        public ICollection<Transaction> Transaction { get; set; }

        public Inventory()
        {
            Transaction = new Collection<Transaction>();
        }
    }
}