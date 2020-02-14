using ExercisesWorkForce.Contracts;
using ExercisesWorkForce.Core;
using ExercisesWorkForce.Models;
using System;

namespace ExercisesWorkForce
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Run();
        }
    }
}
