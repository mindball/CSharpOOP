using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenClosedPrinciple.Design_or_strategy_pattern.AnotherExampleOfGoodStrategyIsMatch.Contracts;

namespace OpenClosedPrinciple.Design_or_strategy_pattern.AnotherExampleOfGoodStrategyIsMatch
{
    public class DrawingManager
    {
        public void Draw(IShape shape)
        {
            //този подход се среща по често отколкото с refletion
            List<IDrawingManager> drawes = new List<IDrawingManager>()
            {
                new RectangleDrawer(),
                new CirleDrawer()
            };

            drawes.First(x => x.IsMatsh(shape)).Draw(shape);

        }
    }
}
