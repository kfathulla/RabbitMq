namespace Producer_Api.Entities
{
    public class Order : Identity
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
