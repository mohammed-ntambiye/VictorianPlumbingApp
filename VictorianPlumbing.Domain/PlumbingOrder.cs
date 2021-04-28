using System.Collections.Generic;

namespace VictorianPlumbing.Domain
{
    public class PlumbingOrder
    {
        public Customer Customer { get; set; }
        public string OrderNumber { get; set; }
        public string BasketCode { get; set; }
        public List<Product> Items { get; set; }
    }
}
