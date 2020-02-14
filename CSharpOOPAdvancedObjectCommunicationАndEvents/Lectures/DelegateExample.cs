using System;
using System.Collections.Generic;
using System.Text;

namespace Lectures
{
   
    class DelegateExample
    {
        public delegate string UppercaseDelegate(string input);

        public string UppercaseFirst(string input)
        {
            char[] buffer = input.ToCharArray();
            buffer[0] = char.ToUpper(buffer[0]);

            return new string(buffer);
        }

        public string UppercaseLast(string input)
        {
            char[] buffer = input.ToCharArray();
            buffer[buffer.Length - 1] = char.ToUpper(buffer[buffer.Length - 1]);

            return new string(buffer);
        }

        public string UppercaseAll(string input)
        {
            return input.ToUpper();
        }

        public void WriteOutput(string input, UppercaseDelegate dele)
        {
            Console.WriteLine($"{input} - {dele(input)}");
        }
    }
}
