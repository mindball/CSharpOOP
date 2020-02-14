using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.LiveDemo.Contracts
{
    public interface IRenderer
    {
        void DrawAt(Shape shape);
    }
}
