using OpenClosedPrinciple.Design_or_strategy_pattern.AnotherExampleOfGoodStrategyIsMatch.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Design_or_strategy_pattern.AnotherExampleOfGoodStrategyIsMatch
{
    public class CirleDrawer : IDrawingManager
    {
        public void Draw(IShape shape)
        {
            //good practice var circ;e = shape as Rectangle; защото сме сигурни че кръг ще извика този метод
            var rectangle = shape as Circle;
            Console.WriteLine("Circle drawed");
        }

        public bool IsMatsh(IShape shape)
        {
            if (shape is Circle)
                return true;

            return false;
        }
    }
}
