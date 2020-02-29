using System;

namespace SourcemakingWithoutRefactoring
{
    public class Gazillion
    {
        private static int num = 0;
        private int row, col;

        public Gazillion(int maxPerRow)
        {
            row = num / maxPerRow;
            col = num % maxPerRow;
            num++;
        }

        public void Report()
        {
            Console.Write(" " + row + col);
        }
    }
    class Program
    {
        public static int ROWS = 6, COLS = 10;
        static void Main(string[] args)
        {
            Gazillion[,] matrix = new Gazillion[ROWS,COLS];
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    matrix[i,j] = new Gazillion(COLS);
                }
            }
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                {
                    matrix[i,j].Report();
                }
                Console.WriteLine();
            }
        }
    }
}
