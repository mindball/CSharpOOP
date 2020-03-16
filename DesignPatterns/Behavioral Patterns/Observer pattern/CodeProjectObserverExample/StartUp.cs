using CodeProjectObserverExample.Models;
using System;

namespace CodeProjectObserverExample
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Subject RedMI = new Subject("Red MI Mobile", 10000, false);
            CodeProjectObserverExample.Contracts.IObserver user1 = 
                new Observer("Ivan Kolev", RedMI);

            CodeProjectObserverExample.Contracts.IObserver user2 =
                new Observer("Dimitar Ivanow", RedMI);

            Console.WriteLine($"Red MI mobile current state: " + (RedMI.IsAvailability ? "available" : "not available"));
            Console.WriteLine();

            RedMI.SetAvailability(true);

        }
    }
}
