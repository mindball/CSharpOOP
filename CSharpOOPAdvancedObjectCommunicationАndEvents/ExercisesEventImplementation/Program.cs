using System;

namespace ExercisesEventImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Dispatcher newDispatcher = new Dispatcher();
            Handler handler = new Handler();

            newDispatcher.NameChange += handler.OnDispatcherNameChange;

            string input = Console.ReadLine();
            while(!input.Equals("End"))
            {
                newDispatcher.Name = input;

                input = Console.ReadLine();
            }
        }
    }
}
