using System;
using System.Collections.Generic;
using System.Text;

namespace WorkShop
{
   public class Finally
    {
        public static void TestTryFinally()
        {
            Console.WriteLine("Code executed before try-finally.");

            try
            {
                string str = Console.ReadLine();
                int.Parse(str);
                Console.WriteLine("Parsing was successful.");
                return; // Exit from the current method 
            }
            catch (FormatException)
            {
                Console.WriteLine("Parsing failed!");
            }
            finally
            {
                //this block always execute, 
                //even exception is raised or not in try block                
                Console.WriteLine("This cleanup code is always executed.");
            }

            Console.WriteLine("This code is after the try-finally block.");
        }
    }
}
