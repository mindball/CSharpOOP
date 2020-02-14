using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static long jediSum = 0;
    static int rows;
    static int cols;
    private static HashSet<String> zeroPositions;

    static void Main(string[] args)
    {
        String[] dimensions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        rows = int.Parse(dimensions[0]);
        cols = int.Parse(dimensions[0]);

        zeroPositions = new HashSet<String>();

        if(rows >= 5 && rows <= 2000 && cols >= 5 && cols <= 2000)
        {
            //string ivoDimension;
            //string evilDimension;
            //while (true)
            //{
            //    ivoDimension = Console.ReadLine();
            //    if (ivoDimension.Equals("Let the Force be with you"))
            //        break;

            //    evilDimension = Console.ReadLine();

            //    string[] ivo = ivoDimension.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //    int ivoRows = int.Parse(ivo[0]);
            //    int ivoCol = int.Parse(ivo[1]);

            //    string[] evil = evilDimension.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            //    int evilRows = int.Parse(evil[0]);
            //    int evilCol = int.Parse(evil[1]);

            //    if (evilRows >= 0 && evilCol < cols)
            //    {

            //    }



            //}
            while (true)
            {
                String input = Console.ReadLine();
                if (input.Equals("Let the Force be with you")) break;

                String[] coordinates = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                int jediRow = int.Parse(coordinates[0]);
                int jediCol = int.Parse(coordinates[1]);

                coordinates = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray(); ;
                int evilRow = int.Parse(coordinates[0]);
                int evilCol = int.Parse(coordinates[1]);

                // process the dark path
                if (evilRow >= rows)
                {
                    int shiftValue = evilRow - rows + 1;
                    evilRow -= shiftValue;
                    evilCol -= shiftValue;
                }

                if (evilCol >= cols)
                {
                    int shiftValue = evilCol - cols + 1;
                    evilRow -= shiftValue;
                    evilCol -= shiftValue;
                }

                while (evilRow >= 0 && evilCol >= 0)
                {
                    zeroPositions.Add(evilRow + " " + evilCol);
                    evilRow--;
                    evilCol--;
                }

                //process the jedi path
                if (jediRow >= rows)
                {
                    int shiftValue = jediRow - rows + 1;
                    jediRow -= shiftValue;
                    jediCol += shiftValue;
                }

                if (jediCol < 0)
                {
                    int shiftValue = Math.Abs(jediCol);
                    jediRow -= shiftValue;
                    jediCol += shiftValue;
                }

                while (jediRow >= 0 && jediCol < cols)
                {
                    if (!zeroPositions.Contains(jediRow + " " + jediCol))
                    {
                        jediSum += jediRow * cols + jediCol;
                    }
                    jediRow--;
                    jediCol++;
                }
            }

            Console.WriteLine(jediSum);

        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }

    }

    
}

