using System;
using System.Collections.Generic;
using System.Text;

namespace trafficSystem.Models
{
    abstract class Vehicle
    {
        VehicleDynamic dynamicProperties;
        VehicleStatic staticProperties;

        public bool TurnOff() {
            return true;
        }

        public  bool Go()
        {
            return true;
        }
        public  bool Stop()
        {
            return true;
        }
        public int Speed()
        {
            return 0;
        }

    }
}
