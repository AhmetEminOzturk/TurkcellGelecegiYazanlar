using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Example
{
    public class PlaneSim
    {
        public void PlaneControll(Plane plane)
        {
            plane.Faster();
            plane.Slower();
        }
    }
}
