using System;
using System.Collections.Generic;
using System.Text;

namespace trafficSystem.Models
{
    class Bulb
    {
        private string bulbType;

        public string BulbType
        {
            get { return bulbType; }
            set { bulbType = value; }
        }
        private string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

    }
}
