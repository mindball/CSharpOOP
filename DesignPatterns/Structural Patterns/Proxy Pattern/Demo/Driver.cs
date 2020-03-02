using System;
using System.Collections.Generic;
using System.Text;

namespace Demo
{
    public class Driver
    {
        private int age;

        public Driver(int age)
        {
            this.age = age;
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
