using DotnettricksExampleFlyweight.Contracts;
using DotnettricksExampleFlyweight.Models;
using System;
using System.Collections.Generic;

namespace DotnettricksExampleFlyweight.Factories
{
    /// <summary>
    /// The 'FlyweightFactory' class
    /// </summary>
    class ShapeObjectFactory
    {
        private readonly Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

        public int TotalObjectsCreated
        {
            get { return shapes.Count; }
        }

        public IShape GetShape(string shapeName)
        {
            IShape shape = null;
            if (!shapes.TryGetValue(shapeName, out shape))
            { 
                switch (shapeName)
                {
                    case "Rectangle":
                        shape = new Rectangle();
                        shapes.Add("Rectangle", shape);
                        break;
                    case "Circle":
                        shape = new Circle();
                        shapes.Add("Circle", shape);
                        break;
                    default:
                        throw new Exception("Factory cannot create the object specified");
                }
            }
            return shape;
        }
    }
}
