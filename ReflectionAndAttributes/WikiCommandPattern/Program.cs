using System;
using WikiCommandPattern.Contracts;
using WikiCommandPattern.Models;

namespace WikiCommandPattern
{
    class Program
    {
        
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            ISwitchable device = new Lamp();

            ICommand onCommand = new OnCommand(device);
            ICommand offCommand = new OffCommand(device);

            Switch @switch = new Switch(onCommand, offCommand);

            switch (input)
            {
                case "On":
                    @switch.On();
                    break;
                case "Off":
                    @switch.Off();
                    break;
            }
        }
    }
}
