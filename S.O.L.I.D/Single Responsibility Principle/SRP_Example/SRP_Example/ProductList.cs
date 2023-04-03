using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Example
{
    public class ProductList
    {
        public List<Product> GetProductsList()
        {            
            List<Product> productList = new List<Product>()
        {
            new Product() { Id = 1, Name = "Hat", Price = 15 },
            new Product() { Id = 2, Name = "Shoes", Price = 50 },
            new Product() { Id = 3, Name = "Umbrella", Price = 30 }
        };

            return productList;
        }
    }
}
