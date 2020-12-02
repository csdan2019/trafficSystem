using System;
using System.Collections.Generic;
using System.Text;

namespace trafficSystem.Models
{
    class Equipment
    {
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        private int power;

        public int Power
        {
            get { return power; }
            set { power = value; }
        }


        // do we even need this if we have status as property?
        public bool GetStatus()
        {
            return status;
        }
    }
}
