using System;
using System.Collections.Generic;
using System.Text;

namespace trafficSystem.Models
{
    class TrafficLight
    {
        private List<Bulb> bulbsList;

        public List<Bulb> Bulbs
        {
            get { return bulbsList; }
            set { bulbsList = value; }
        }


    }
}
