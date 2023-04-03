using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Example
{
    public class Order
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
