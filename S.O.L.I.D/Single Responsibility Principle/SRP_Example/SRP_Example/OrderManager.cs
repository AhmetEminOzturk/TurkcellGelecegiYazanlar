using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Example
{
    public class OrderManager
    {
        public void CreateOrder(Order order)
        {
            
            Console.WriteLine("Order created Id: " + order.Id);

            Console.WriteLine("Shopping Total Amount:" + order.TotalAmount);
        }
    }
}
