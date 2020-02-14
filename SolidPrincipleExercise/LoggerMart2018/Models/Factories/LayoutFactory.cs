using System;
using LoggerMart2018.Models.Contracts;

namespace LoggerMart2018.Models.Factories
{
    public class LayoutFactory
    {
        public ILayout CreateLayout(string layoutType)
        {
            ILayout layout = null;

            switch(layoutType)
            {
                case "SimpleLayout":
                    layout =  new SimpleLayout();
                    break;
                default:
                    throw new ArgumentException("Invalid Layout type!!!");
            }

            return layout;
        }
    }
}
