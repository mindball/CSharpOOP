using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WikiExample.Contracts;

namespace WikiExample.Models
{
    /// <summary>
    /// Composite
    /// Collection of child graphics.
    /// </summary>
    public class CompositeGraphic : IGraphic
    {
        private readonly List<IGraphic> childGraphics = new List<IGraphic>();

        public void AddGraphic(IGraphic graphic)
        {
            this.childGraphics.Add(graphic);
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
