using System;
using System.Collections.Generic;
using System.Text;

namespace trafficSystem.Models
{
    public class Person
    {
        // change age and speed to property
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        private int walkingSpeed;

        public int WalkingSpeed
        {
            get { return walkingSpeed; }
            set { walkingSpeed = value; }
        }


        public int Walk()
        {
            return 0;

        }
        public int Run()
        {
            return 0;
        }
    }
}
