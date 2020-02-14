using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSteps = int.Parse(Console.ReadLine());
            int countDancers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double test = (double)(countSteps / days )/ (double)countSteps * 100;
            if(test < 1)
            {
                test *= 10;
            }

            double learnDaySteps = Math.Ceiling(test);
            double result = learnDaySteps / countDancers;

            if(learnDaySteps > 13)
                Console.WriteLine("No, They will not succeed in that goal! Required {0:0.00}% steps to be learned per day.", result);
            else
                Console.WriteLine("Yes, they will succeed in that goal! {0:0.00}%.", result);
        }
        
    }
}
