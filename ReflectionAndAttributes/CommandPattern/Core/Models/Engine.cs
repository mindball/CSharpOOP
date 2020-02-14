using CommandPattern.Core.Contracts;
using System;

namespace CommandPattern.Core.Models
{
    public class Engine : IEngine
    {
       private ICommandInterpreter commandInterpreter;
        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (true)
            {               
                string result = this.commandInterpreter.Read(input);

                if(result is null)
                {
                    return;
                }
                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }
    }
}
