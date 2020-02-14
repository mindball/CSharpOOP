using System;

namespace SimpleSnake.GameObjects
{
    public class Point
    {
        private int leftX;
        private int topY;

        public Point(int leftX, int topY)
        {
            this.LeftX = leftX;
            this.TopY = topY;
        }

        public int TopY
        {
            get { return topY; }
            set
            {
                //TODO think about direction
                if (value < -1 || value > Console.WindowHeight)
                {
                    throw new IndexOutOfRangeException();
                }

                topY = value;
            }
        }

        public int LeftX
        {
            get { return leftX; }
            set
            {
                //TODO think about direction
                if (value < -1 || value > Console.WindowWidth)
                {
                    throw new IndexOutOfRangeException();
                }

                leftX = value;
            }
        }

        /// <summary>
        /// Draw a current object symbol inside of wall borders
        /// </summary>
        /// <param name="symbol"></param>
        public void Draw(char symbol)
        {
            Console.SetCursorPosition(this.LeftX, this.TopY);
            Console.Write(symbol);
        }


        /// <summary>
        ///  Create a wall borders
        /// </summary>
        /// <param name="leftX"></param>
        /// <param name="topY"></param>
        /// <param name="symbol"></param>
        public void Draw(int leftX, int topY, char symbol)
        {
            Console.SetCursorPosition(leftX, topY);
            Console.Write(symbol);
        }

    }
}
