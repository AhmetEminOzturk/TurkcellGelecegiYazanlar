using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessor processor = new PaymentProcessor();

            IPayment creditCardPayment = new CreditCardPayment();
            processor.ProcessPayment(creditCardPayment);

            IPayment cashPayment = new CashPayment();
            processor.ProcessPayment(cashPayment);

            Console.ReadLine();
        }
    }
}
