using DependencyInversion.LiveDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.LiveDemo
{
    class HtmlRenderer : IRenderer
    {
        public void DrawAt(Shape shape)
        {
            //нов метод за печатане
        }
    }
}
