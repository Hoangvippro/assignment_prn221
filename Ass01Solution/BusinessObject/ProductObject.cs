using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    internal class ProductObject
    {
        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public int CategoryId { get; set; }
        public String Weight { get; set; }
        public float UnitPrice { get; set; }
        public int UnitslnStock { get; set; }
    }
}
