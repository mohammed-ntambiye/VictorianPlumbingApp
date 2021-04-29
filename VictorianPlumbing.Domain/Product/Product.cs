namespace VictorianPlumbing.Domain
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string SkuCode { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
