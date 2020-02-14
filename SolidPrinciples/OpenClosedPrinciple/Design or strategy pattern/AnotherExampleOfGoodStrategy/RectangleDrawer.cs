using OpenClosedPrinciple.Design_or_strategy_pattern.AnotherExampleOfGoodStrategy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Design_or_strategy_pattern.AnotherExampleOfGoodStrategy
{
    public class RectangleDrawer : IDrawingManager
    {
        //
        public void Draw(IShape shape)
        {
            //good practice var rectangle = shape as Rectangle; защото сме сигурни че правоъгълник ще извика този метод
            var rectangle = shape as Rectangle;
            throw new NotImplementedException();
        }
    }
}
