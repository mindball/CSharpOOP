using System;
using System.Text;
using DemoVisitorPattern.Contracts;
using System.Collections.Generic;

namespace DemoVisitorPattern.Models
{
    public class XMLExportVisitor : IVisitor
    {
        public string Export(params IShape[] shapes)
        {
            StringBuilder sb = new StringBuilder();
            foreach (IShape shape in shapes)
            {
                sb.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>" + "\n");
                sb.AppendLine(shape.Accept(this));
                Console.Write(sb.ToString());
                sb.Clear();
                Console.WriteLine();
            }
            
            return sb.ToString();
        }

        public string VisitDot(Dot d)
        {
            return "<dot>" + "\n" +
                    "    <id>" + d.GetId() + "</id>" + "\n" +
                    "    <x>" + d.GetX() + "</x>" + "\n" +
                    "    <y>" + d.GetY() + "</y>" + "\n" +
                    "</dot>";
        }

        public string VisitCircle(Circle c)
        {
            return "<circle>" + "\n" +
                    "    <id>" + c.GetId() + "</id>" + "\n" +
                    "    <x>" + c.GetX() + "</x>" + "\n" +
                    "    <y>" + c.GetY() + "</y>" + "\n" +
                    "    <radius>" + c.GetRadius() + "</radius>" + "\n" +
                    "</circle>";
        }

        public string VisitRectangle(Rectangle r)
        {
            return "<rectangle>" + "\n" +
                    "    <id>" + r.GetId() + "</id>" + "\n" +
                    "    <x>" + r.GetX() + "</x>" + "\n" +
                    "    <y>" + r.GetY() + "</y>" + "\n" +
                    "    <width>" + r.GetWidth() + "</width>" + "\n" +
                    "    <height>" + r.GetHeight() + "</height>" + "\n" +
                    "</rectangle>";
        }

        public string VisitCompoundGraphic(CompoundShape cg)
        {
            return "<compound_graphic>" + "\n" +
                    "   <id>" + cg.GetId() + "</id>" + "\n" +
                    this._VisitCompoundGraphic(cg) +
                    "</compound_graphic>";
        }

        private string _VisitCompoundGraphic(CompoundShape cg)
        {
            StringBuilder sb = new StringBuilder();
            foreach (IShape shape in cg.Shapes)
            {
                string obj = shape.Accept(this);
                // Proper indentation for sub-objects.
                obj = "    " + obj.Replace("\n", "\n    ") + "\n";
                sb.Append(obj);
            }
            return sb.ToString();
        }
    }
}
