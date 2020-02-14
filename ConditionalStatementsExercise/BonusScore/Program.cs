using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class Program
    {
        public static int number;
        public static int bonusEvenNumber = 5;        

        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out number);
           

            if (number <= 100)
            {
                bonusEvenNumber += CalculateBonusEvenNumber(number);
                Console.WriteLine(bonusEvenNumber);
                Console.WriteLine(bonusEvenNumber + number);               
            }
            else if(number > 100 && number <= 1000 )
            {
                double resultBonus = (number * 0.20);
                resultBonus += CalculateBonusEvenNumber(number);
                Console.WriteLine("{0:0.0}", resultBonus);
                Console.WriteLine("{0:0.0}", (resultBonus + number));
            }
            else
            {
                //float point
                double resultBonus = (number * 0.10);
                resultBonus += CalculateBonusEvenNumber(number);
                Console.WriteLine("{0:0.0}", resultBonus);
                Console.WriteLine("{0:0.0}", (resultBonus + number));
            }

        }

        public static int CalculateBonusEvenNumber(int n)
        {
            int tempBonus = 0;
            if (number % 2 == 0)
            {
                tempBonus += 1;
                return tempBonus;
            }
            else if (number % 10 == 5)
            {
                tempBonus += 2;
                return tempBonus;
            }
            else
                return tempBonus;
                
        }
    }
}
