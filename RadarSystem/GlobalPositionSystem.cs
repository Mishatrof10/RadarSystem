using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadarSystem
{
    class GlobalPositionSystem : IGPS
    {
       public double S { get; set; }
       public double N { get; set; }

        public void SetGPS(double _S, double _N)
        {
            S = _S;
            N = _N;
        }
    }
}
