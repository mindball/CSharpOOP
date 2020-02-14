using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            double minSallary = double.Parse(Console.ReadLine());
            double minScoolSuccess = 4.50;
            double excellentSuccess = 5.5;
            


            
            if(minSallary < income && averageSuccess < excellentSuccess)
            {
                Console.WriteLine("You cannot get a scholarship!");
                //double Scholarship = minSallary * 0.35;
            }
            else
            {
                double socialScholarship = minSallary * 0.35;

                bool isExcellentSuccess = averageSuccess > excellentSuccess;
                double excellentSuccessScholarship = 0.0;
                if (isExcellentSuccess)
                {
                    excellentSuccessScholarship = averageSuccess * 25;
                }

                
                if(excellentSuccessScholarship > socialScholarship)
                {
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(excellentSuccessScholarship));
                }
                else if(averageSuccess < minScoolSuccess)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }
                else
                {
                    Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(socialScholarship));
                }
            }
        }
    }
}
