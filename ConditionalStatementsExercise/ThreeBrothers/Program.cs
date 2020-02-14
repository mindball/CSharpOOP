using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBrotherHour = double.Parse(Console.ReadLine());
            double secondtBrotherHour = double.Parse(Console.ReadLine());
            double thirdBrotherHour = double.Parse(Console.ReadLine());
            double fatherHour = double.Parse(Console.ReadLine());
            double summaryHoursWithRest = 0;

            firstBrotherHour = firstBrotherHour == 0 ? 0 : (1 / firstBrotherHour);
            secondtBrotherHour = secondtBrotherHour == 0 ? 0 : (1 / secondtBrotherHour);
            thirdBrotherHour = thirdBrotherHour == 0 ? 0 : (1 / thirdBrotherHour);

            if(firstBrotherHour == 0 && secondtBrotherHour == 0 && thirdBrotherHour == 0)
                summaryHoursWithRest = 0;
            else
            {
                summaryHoursWithRest = (1 / (firstBrotherHour +
                                         secondtBrotherHour +
                                        thirdBrotherHour)) * 1.15;
            }
           

            //supprice result
            int result = Convert.ToInt32(Math.Floor(fatherHour - summaryHoursWithRest));
            //isn't a surprise 
            int resultTwo = Math.Abs(Convert.ToInt32(Math.Ceiling(summaryHoursWithRest)));
           
            if (result >= 0)
            {
                Console.WriteLine("Cleaning time: {0:0.00}", summaryHoursWithRest);
                Console.WriteLine("Yes, there is a surprise - time left -> {0} hours.", result);
            }
            else
            {
                Console.WriteLine("Cleaning time: {0:0.00}", summaryHoursWithRest);
                Console.WriteLine("No, there isn't a surprise - shortage of time -> {0} hours.", resultTwo);
            }    
           



        }
    }
}
