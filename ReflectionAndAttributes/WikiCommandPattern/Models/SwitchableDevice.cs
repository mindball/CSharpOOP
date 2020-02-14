using System;
using System.Collections.Generic;
using System.Text;
using WikiCommandPattern.Contracts;

namespace WikiCommandPattern.Models
{
    public abstract class SwitchableDevice : ISwitchable
    {
        
        public void Off()
        {
            Console.WriteLine($"{this.GetType().Name} is off");
        }

        public void On()
        {
            Console.WriteLine($"{this.GetType().Name} is on");

        }
    }
}
