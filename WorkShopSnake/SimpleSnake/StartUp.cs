using SimpleSnake.Core;
using SimpleSnake.GameObjects;
using SimpleSnake.GameObjects.Foods;
using System;

namespace SimpleSnake
{
    public class StartUp
    {
        public static void Main()
        {

            Console.WriteLine($"\u25CC");
            Wall wall = new Wall(60, 20);           
            Snake snake = new Snake(wall);

            Engine engine = new Engine(snake, wall);
            engine.Run();

        }
    }
}
