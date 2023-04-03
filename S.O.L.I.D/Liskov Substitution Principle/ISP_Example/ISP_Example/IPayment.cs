using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Example
{
    public interface IPayment
    {
        void ProcessPayment();
        decimal CalculatePrice();
    }
}
