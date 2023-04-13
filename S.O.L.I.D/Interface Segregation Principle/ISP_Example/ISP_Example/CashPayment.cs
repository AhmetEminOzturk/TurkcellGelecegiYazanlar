using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Example
{
    public class CashPayment : IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing cash payment");
        }

        public decimal CalculatePrice()
        {
            Console.WriteLine("Calculating payment for cash");
            return 50;
        }
    }
}
