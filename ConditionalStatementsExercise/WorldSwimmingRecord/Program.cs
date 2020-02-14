using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double worldRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double timeToSwim = double.Parse(Console.ReadLine());

            timeToSwim *= distance;
            double temp = Math.Floor(distance / 15) * 12.5;
            double summuryTime = timeToSwim + temp;
            if(worldRecord < summuryTime)
                Console.WriteLine("No, he failed! He was {0:0.00} seconds slower.", (summuryTime - worldRecord) );
            else
                Console.WriteLine("Yes, he succeeded! The new world record is {0} seconds.", summuryTime);


        }
    }
}
