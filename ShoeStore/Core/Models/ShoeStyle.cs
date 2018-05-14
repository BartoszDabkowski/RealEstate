namespace ShoeStore.Core.Models
{
    public class ShoeStyle
    {
        public int ShoeId { get; set; }
        public Shoe Shoe { get; set; }
        public int StyleId { get; set; }
        public Style Style { get; set; }
    }
}