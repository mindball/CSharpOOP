using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            string hours = Console.ReadLine();
            string minutes = Console.ReadLine();
            string timeInMinAndHours = hours + ":" +  minutes;
                
            TimeSpan s1 = TimeSpan.Parse("0:15");
            TimeSpan s2 = TimeSpan.Parse(timeInMinAndHours);
            

            TimeSpan s3 = s1 + s2;
            //Custom TimeSpam          
            Console.WriteLine(s3.ToString(@"h\:mm"));
        }
    }
}
