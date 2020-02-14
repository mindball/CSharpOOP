using OpenClosedPrinciple.Design_or_strategy_pattern.AnotherExampleOfGoodStrategyIsMatch.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Design_or_strategy_pattern.AnotherExampleOfGoodStrategyIsMatch
{
    public class RectangleDrawer : IDrawingManager
    {
        public void Draw(IShape shape)
        {
            //good practice var rectangle = shape as Rectangle; защото сме сигурни че правоъгълник ще извика този метод
            var rectangle = shape as Rectangle;
            Console.WriteLine("Reg drawed");
        }

        public bool IsMatsh(IShape shape)
        {
            if (shape is Rectangle)
                return true;

            return false;
        }
    }
}
