using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple.Design_or_strategy_pattern.AnotherExampleOfGoodStrategy.Contracts
{
    public interface IDrawingManager
    {
        //
        void Draw(IShape shape);
    }
}
