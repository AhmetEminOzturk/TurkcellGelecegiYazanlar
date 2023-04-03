using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ProductList productList = new ProductList();
            List<Product> products = productList.GetProductsList();

            
            Order order = new Order()
            {
                Id = 1,
                Products = products,
                TotalAmount = products.Sum(p => p.Price)
            };

  
            OrderManager orderManagement = new OrderManager();
            orderManagement.CreateOrder(order);

            Console.ReadLine();
        }
    }
    
}
