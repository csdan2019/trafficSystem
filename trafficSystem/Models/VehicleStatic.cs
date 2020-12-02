using System;
using System.Collections.Generic;
using System.Text;

namespace trafficSystem.Models
{
    class VehicleStatic
    {
        private int fuel;

        public int Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }


        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        Person driver;
        List<Person> passengers; 

    }
}
