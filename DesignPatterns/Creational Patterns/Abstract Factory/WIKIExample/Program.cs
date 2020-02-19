using System;
using WIKIExample.Contracts;
using WIKIExample.Factories;

namespace WIKIExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Array values = Enum.GetValues(typeof(OSSettings));
            Random random = new Random();
            OSSettings randomBar = (OSSettings)values.GetValue(random.Next(values.Length));

            IGUIFactory factory;
            switch (randomBar)
            {
                case OSSettings.Win:
                    factory = new WinFactory();
                    break;
                case OSSettings.OSX:
                    factory = new OSXFactory();
                    break;
                default:
                    throw new System.NotImplementedException();
            }

            var button = factory.CreateButton();
            button.Paint();
        }
    }
}
