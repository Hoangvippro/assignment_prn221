using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    internal class OrderDetailObject
    {
        public int OrderId { get; set; }
        public float Discount { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public OrderObject order { get; set; }
    }
}
