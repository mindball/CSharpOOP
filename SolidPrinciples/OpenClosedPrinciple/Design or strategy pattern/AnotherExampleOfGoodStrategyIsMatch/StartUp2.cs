using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Design_or_strategy_pattern.AnotherExampleOfGoodStrategyIsMatch
{
    class StartUp2
    {
        static void Main(string[] args)
        {
            Circle peshoCirle = new Circle();
            Circle peshoCirle1 = new Circle();
            

            Rectangle goshoRec = new Rectangle();
            Rectangle goshoRec1 = new Rectangle();
            

            var drawler = new DrawingManager();
            drawler.Draw(peshoCirle);
            drawler.Draw(peshoCirle1);
            drawler.Draw(goshoRec);
            drawler.Draw(goshoRec1);

        }
    }
}
