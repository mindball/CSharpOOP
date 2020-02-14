

namespace PetClinics
{
    using System;
    using Core;
    class StartUp
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Engine engine = new Engine();
            engine.Run(input);
        }
    }
}
