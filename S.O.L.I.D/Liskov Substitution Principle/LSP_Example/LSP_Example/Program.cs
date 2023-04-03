using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlaneSim sim = new PlaneSim();
            sim.PlaneControll(new Bayraktar());
            sim.PlaneControll(new F16());
        }
    }
}
