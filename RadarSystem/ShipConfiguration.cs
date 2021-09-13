using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadarSystem
{
    struct ShipConfiguration
    {
        double S;
        double N;
        double CurrentSpeed;
        string NameShip;

        public ShipConfiguration(double _S, double _N, double _CurrentSpeed, string _NameShip)
        {
            S = _S;
            N = _N;
            CurrentSpeed = _CurrentSpeed;
            NameShip = _NameShip;
        }

        public override string ToString()
        {
            return string.Format($"Судно: {NameShip} \n По координатам: \nN: {N} \nS: {S} \nИдёт со скоростью: {CurrentSpeed}");
        }
    }
}
