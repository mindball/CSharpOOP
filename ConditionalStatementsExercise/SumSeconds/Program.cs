using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static int firstPlayerSec;
        static int secondPlayerSec;
        static int thirdPlayerSec;

        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out firstPlayerSec);
            int.TryParse(Console.ReadLine(), out secondPlayerSec);
            int.TryParse(Console.ReadLine(), out thirdPlayerSec);
            int sumSec = firstPlayerSec + secondPlayerSec + thirdPlayerSec;

            int minutes = sumSec / 60;
            int remSec = sumSec % 60;
            

            if(remSec == 0)
            {
                Console.WriteLine("{0}:00", minutes);
            }
            else if (minutes < 1 && remSec < 10)
            {
                Console.WriteLine("{0}:0{1}", minutes, remSec);
            }
            else if(minutes < 1 && remSec > 10 && remSec < 60)
            {
                Console.WriteLine("{0}:{1}", minutes, remSec);
            }
            else if(minutes >= 1 && remSec < 10)
            {
                Console.WriteLine("{0}:0{1}", minutes, remSec);
            }
            else if (minutes >= 1 && remSec >= 10 && remSec < 60)
            {
                Console.WriteLine("{0}:{1}", minutes, remSec);
            }
        }
    }
}
