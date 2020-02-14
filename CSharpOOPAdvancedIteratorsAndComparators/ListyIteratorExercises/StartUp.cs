using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIteratorExercises
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            //There will always be only 1 Create command and it will always be the first command passed.
            string[] inputArguments = input.Split().Skip(1).ToArray();

            ListyIterator<string> listy;
            if (inputArguments.Length == 0)
            {
                listy = new ListyIterator<string>();
            }
            else
            {
                listy = new ListyIterator<string>(inputArguments);
            }

            string secondInput = Console.ReadLine();
            while (!secondInput.Equals("END"))
            {
                switch (secondInput)
                {
                    case "Move":
                        Console.WriteLine(listy.Move());
                        break;
                    case "HasNext":
                        Console.WriteLine(listy.HasNext());
                        break;
                    case "Print":
                        try
                        {
                            Console.WriteLine(listy.Print());
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                }

                secondInput = Console.ReadLine();
            }

            foreach (var item in listy)
            {
                Console.WriteLine(item);
            }
        }

    }
}
