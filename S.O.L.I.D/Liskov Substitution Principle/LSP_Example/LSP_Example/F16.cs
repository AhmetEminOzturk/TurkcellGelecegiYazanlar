using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Example
{
    public class F16 : Plane
    {
        public override void Faster()
        {
            Console.WriteLine("Fast +50");
        }


        public override void Slower()
        {
            Console.WriteLine("Slow -50");
        }
    }
}
