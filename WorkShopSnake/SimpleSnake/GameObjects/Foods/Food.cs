using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleSnake.GameObjects.Foods
{
    public abstract class Food : Point
    {
        private Random random;
        private char foodSymbol;
        Wall wall;

        public Food(Wall wall, char foodSymbol, int points)
            : base(wall.LeftX, wall.TopY)
        {
            this.wall = wall;
            this.foodSymbol = foodSymbol;
            this.random = new Random();
            this.FoodPoints = points;
        }

        public int FoodPoints { get; private set; }

        public void SetRandomPosition(Queue<Point> snakeElements)
        {
            bool isPointOfSnake = SetPointsOfFood(snakeElements);

            while (isPointOfSnake)
            {                
                isPointOfSnake = SetPointsOfFood(snakeElements);
            }

            //Console.BackgroundColor = ConsoleColor.Red;
            this.Draw(foodSymbol);
            //Console.BackgroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Set coordinate of food and check
        ///     * crossing borders
        ///     * matching the snake's body
        /// </summary>
        /// <param name="snakeElements"></param>
        /// <returns></returns>
        private bool SetPointsOfFood(Queue<Point> snakeElements)
        {
            this.LeftX = this.random.Next(2, this.wall.LeftX - 2);
            //this.TopY = this.random.Next(this.wall.TopY - 2, 2);
            this.TopY = this.random.Next(2, this.wall.TopY);

            bool isPointOfSnake = snakeElements.Any(x => x.TopY == this.TopY &&
                                    x.LeftX == this.LeftX);

            return isPointOfSnake;
        }

        public bool IsFoodPoint(Point snake)
        {
            return this.LeftX == snake.LeftX &&
                this.TopY == snake.TopY;
        }
    }
}
