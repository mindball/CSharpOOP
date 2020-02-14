using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDelegate
{
    class ExampleDelegate
    {
        public delegate int NumberChanger(int number);
        static int num = 0;

        public static int SumNumber(int number)
        {
            Console.WriteLine("Operation 'Sum'");
            num += number;
            return num;
        }

        public static int MultNumber(int number)
        {
            Console.WriteLine("Operation 'Multiply'");
            num *= number;
            return num;
        }

        public static int GetNumber()
        {
            return num;
        }
        
        static void Main(string[] args)
        {
            NumberChanger operateNumber = new NumberChanger(SumNumber);
            //Multicast delegate
            operateNumber += MultNumber;

            operateNumber(5);

            Console.WriteLine(GetNumber());
        }
    }
}
