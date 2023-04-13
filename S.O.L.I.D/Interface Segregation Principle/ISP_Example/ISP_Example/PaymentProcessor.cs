using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Example
{
    public class PaymentProcessor
    {
        public void ProcessPayment(IPayment payment)
        {
            payment.ProcessPayment();
            decimal price = payment.CalculatePrice();
            Console.WriteLine($"Amount: {price:TL}");
        }
    }
}
