using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
  
    class Program
    {
        static double distance;
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out distance);
            string measurement = Console.ReadLine();
            string convertMeasurement = Console.ReadLine();

            if(measurement.Equals(convertMeasurement))
            {
                Console.WriteLine("{0:0.00000000}",distance);
                
            }
            else if(measurement == "m")
            {
                Converter(convertMeasurement, distance);
            }
            else if(convertMeasurement == "m")
            {
                Console.WriteLine("{0:0.00000000}", ConvertToMeters(measurement, distance));
            }
            else
            {
                distance = ConvertToMeters(measurement, distance);
                Converter(convertMeasurement, distance);
            }
           

          

        }

        public static double ConvertToMeters(string m, double d)
        {
            switch (m)
            {
                case "mm":
                    d /= 1000;
                    break;
                case "cm":
                    d /= 100;
                    break;
                case "mi":
                    d *= 1609.344;
                    break;
                case "in":
                    d *= 0.0254;
                    break;
                case "km":
                    d *= 1000;
                    break;
                case "ft":
                    d *= 0.3048;
                    break;
                case "yd":
                    d *= 0.9144;
                    break;
            }
            return d;
        }
        public static void Converter(string c, double d)
        {
            switch (c)
            {
                case "mm":
                    Console.WriteLine("{0:0.00000000}", d * 1000);
                    break;
                case "cm":
                    Console.WriteLine("{0:0.00000000}", d * 100);
                    break;
                case "mi":
                    Console.WriteLine("{0:0.00000000}", (d / 1609.344));
                    break;
                case "in":
                    Console.WriteLine("{0:0.00000000}", (d * 39.3700787));
                    break;
                case "km":
                    Console.WriteLine("{0:0.00000000}", (d / 1000));
                    break;
                case "ft":
                    Console.WriteLine("{0:0.00000000}", (d * 3.2808399));
                    break;
                case "yd":
                    Console.WriteLine("{0:0.00000000}", (d * 1.0936133));
                    break;
            }
        }
    }
}
