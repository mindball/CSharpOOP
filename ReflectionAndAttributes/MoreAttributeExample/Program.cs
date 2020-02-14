//#define PERLS
#define DEBUG
#undef DOT
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConditionalAttributeExample
{
    /*It isn't possible to use Conditional on methods that return a value.
     * Methods must be used in the void context.
     * 
     * */

    class Program
    {
        public static void Main()
        {
            MethodA();
            MethodB();

            List<string> l = new List<string>();
            l.Add("rabbit");
            l.Add("bird");
            AddToArray(l);
            Console.WriteLine("Elements: {0}", l.Count);
            Console.Read();
        }

        [Conditional("DEBUG")]
        private static void AddToArray(List<string> l)
        {
            // New array
            string[] a = new string[2];
            a[0] = "cat";
            a[1] = "mouse";
            // Add array to end of list
            l.AddRange(a);
        }

        [Conditional("PERLS")]
        static void MethodA()
        {
            Console.WriteLine("Print Method 'A'");
        }

        [Conditional("DOT")]
        static void MethodB()
        {
            Console.WriteLine("Print Method 'B'");
        }
    }
}
