using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastDelegate
{
    class MulticastDelegate
    {
        delegate int MDelegate<T>(T value);
        static void Main(string[] args)
        {
            //List of delegate. First execute PrintString(test), second PrintStringLenght(test), and first len equal 1, and last len = 2 (list of method)
            MDelegate<string> d = MulticastDelegate.PrintString; 
            d += new MulticastDelegate().PrintStringLenght;
            string test = "test";
            int len = d(test);

            //anonymous 
            d += delegate (string str)
            {
                Console.WriteLine("Test 3");
                return 3;
            };
        }

        public static int PrintString(string str)
        {
            Console.WriteLine($"String: {str}");
            return 1;
        }

        public int PrintStringLenght(string str)
        {
            Console.WriteLine($"String len: {str.Length}");
            return str.Length;
        }

    }
}
