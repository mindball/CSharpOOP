using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesDependencyInversion.Core
{
    using Contracts;
    using Factories;
    class Engine
    {
        private CalculationStrategyFactory strategyFactory;
        public Engine()
        {
            strategyFactory = new CalculationStrategyFactory();
        }
        public void Run()
        {
            string input = Console.ReadLine();
            //Default strategy: AdditionalStrategy
            ICalculationStrategy strategy = strategyFactory.CreateStrategy(new char());

            while(!input.Equals("End"))
            {
                string[] args = input.Split();
                if(args[0].Equals("mode"))
                {
                    char command = char.Parse(args[1]);
                    strategy = strategyFactory.CreateStrategy(command);                   
                }
                else
                {
                    int firstOperand = int.Parse(args[0]);
                    int secondOperand = int.Parse(args[1]);

                    int result = strategy.Calculate(firstOperand, secondOperand);
                    Console.WriteLine(result);
                }
                

                input = Console.ReadLine();
            }
        }
    }
}
