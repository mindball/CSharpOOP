using System;
using System.Collections.Generic;

namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArguments = input.Split(',', ' ', StringSplitOptions.RemoveEmptyEntries);

            Stone[] stones = new Stone[inputArguments.Length];
            for (int i = 0; i < inputArguments.Length; i++)
            {
                stones[i] = new Stone(int.Parse(inputArguments[i]));
            }

            Lake<Stone> lake = new Lake<Stone>(stones);

            if (stones.Length <= 1)
                Console.WriteLine(stones[0]);
            else
                SegregateCollectionByIndex(lake);


        }

        private static void SegregateCollectionByIndex(Lake<Stone> lake)
        {
            Stack<Stone> stoneOnEvenIndex = new Stack<Stone>();
            Queue<Stone> stoneOnOddIndex = new Queue<Stone>();

            int index = 1;
            foreach (var stone in lake)
            {
                if ((index % 2) != 0)
                    stoneOnOddIndex.Enqueue(stone);
                else
                    stoneOnEvenIndex.Push(stone);
                index++;
            }

            PrintStoneCollectionByOddIndex(stoneOnOddIndex);
            PrintStoneCollectionByEvenIndex(stoneOnEvenIndex);


        }
        public static void PrintStoneCollectionByOddIndex(Queue<Stone> stoneOnOddIndex)
        {
            foreach (var stone in stoneOnOddIndex)
            {
                Console.Write($"{stone}, ");
            }

        }

        public static void PrintStoneCollectionByEvenIndex(Stack<Stone> stoneOnEvenIndex)
        {
            int lenght = 0;
            foreach (var stone in stoneOnEvenIndex)
            {
                if (lenght < stoneOnEvenIndex.Count - 1)
                    Console.Write($"{stone}, ");
                else
                {
                    Console.Write($"{stone}");
                }

                lenght++;
            }
        }

    }
}
