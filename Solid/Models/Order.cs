namespace Solid.Models
{
    public class Order
    {
        public string Product { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
        public Client Customer { get; set; }
    }
}
