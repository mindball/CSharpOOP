using System;
using System.Collections.Generic;
using System.Text;
using OpenClosedPrinciple.Design_or_strategy_pattern.AnotherExampleOfGoodStrategy.Contracts;

namespace OpenClosedPrinciple.Design_or_strategy_pattern.AnotherExampleOfGoodStrategy
{
    public class DrawingManager : IDrawingManager
    {
        public void Draw(IShape shape)
        {
            //тук проверката със "is" e проста затова е добра практикра
            IDrawingManager drawer = null;
            if(shape is Circle)
            {
                drawer = new CirleDrawer();
            }
            else if (shape is Rectangle)
            {
                drawer = new RectangleDrawer();
            }

            drawer.Draw(shape);
        }
    }
}
