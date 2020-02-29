using System;

namespace Sourcemaking
{
    //In this refactoring, the "row" state is considered shareable 
    //(within each row anyways), and the "col" state has been externalized
    //(it is supplied by the client when report() is called).
    
    public class Gazillion
    {
        private int row;

        public Gazillion(int row)
        {
            this.row = row;
            Console.WriteLine("ctor: " + this.row);
        }

        public void Report(int col)
        {
            Console.Write(" " + row + col);
        }
    }

    public class Factory
    {
        private Gazillion[] pool;

        public Factory(int maxRows)
        {
            pool = new Gazillion[maxRows];
        }

        public Gazillion getFlyweight(int row)
        {
            if (pool[row] == null)
            {
                pool[row] = new Gazillion(row);
            }
            return pool[row];
        }
    }

    class StartUp
    {
        private const int ROWS = 6;
        private const int COLS = 10;

        static void Main(string[] args)
        {
            Factory theFactory = new Factory(ROWS);
            for (int i = 0; i < ROWS; i++)
            {
                for (int j = 0; j < COLS; j++)
                    theFactory.getFlyweight(i).Report(j);
                Console.WriteLine();
            }
        }
    }
}
