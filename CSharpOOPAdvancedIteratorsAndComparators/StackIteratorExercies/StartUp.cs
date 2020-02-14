using System;
using System.Linq;

namespace StackIteratorExercies
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            char[] splitDelimeters = { ',', ' ' };
            string[] inputArguments = input.Split(splitDelimeters, StringSplitOptions.RemoveEmptyEntries);
            string command = inputArguments[0];

            MyStack<string> myStack = new MyStack<string>(new string[inputArguments.Length - 1]);

            while (!command.Equals("END"))
            {
                switch (command)
                {
                    case "Push":
                        string[] elements = inputArguments.Skip(1).ToArray();
                        PushElementInStack(elements, myStack);
                        break;
                    case "Pop":
                        myStack.Pop();
                        break;
                }

                input = Console.ReadLine();
                inputArguments = input.Split(splitDelimeters, StringSplitOptions.RemoveEmptyEntries);
                command = inputArguments[0];
            }

            if(myStack.Capacity == 0)
                Console.WriteLine("No elements");
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    foreach (var item in myStack)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }

        private static void PushElementInStack(string[] elements, MyStack<string> myStack)
        {
            foreach (var element in elements)
            {
                myStack.Push(element);
            }
        }
    }
}
