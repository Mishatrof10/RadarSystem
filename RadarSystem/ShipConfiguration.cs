using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadarSystem
{
    struct ShipConfiguration
    {
        GlobalPositionSystem GPS;
        double CurrentSpeed { get; set; }
        string NameShip { get; set; }

        public ShipConfiguration(GlobalPositionSystem _GPS, double _CurrentSpeed, string _NameShip)
        {
            GPS = _GPS;
            CurrentSpeed = _CurrentSpeed;
            NameShip = _NameShip;
        }

        public override string ToString()
        {
            return string.Format($"Судно: {NameShip} \n По координатам: \nN: {GPS.N} \nS: {GPS.S} \nИдёт со скоростью: {CurrentSpeed}");
        }
    }
}
