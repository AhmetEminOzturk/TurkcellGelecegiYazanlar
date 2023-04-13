using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Example
{
    public class CreditCardPayment:IPayment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Processing credit card payment");
        }

        public decimal CalculatePrice()
        {
            Console.WriteLine("Calculating payment for credit card");
            return 100;
        }
    }
}
