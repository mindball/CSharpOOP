using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WikiExample.Models;

namespace WikiExample
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CompositeGraphic graphic = new CompositeGraphic();


            Ellipse ellipse1 = new Ellipse();
            Ellipse ellipse2 = new Ellipse();
            Ellipse ellipse3 = new Ellipse();
            Ellipse ellipse4 = new Ellipse();

            CompositeGraphic graphic1 = new CompositeGraphic();
            graphic1.AddGraphic(ellipse1);
            graphic1.AddGraphic(ellipse2);
            graphic1.AddGraphic(ellipse3);
            graphic1.AddGraphic(ellipse4);

            CompositeGraphic graphic2 = new CompositeGraphic();
            graphic2.AddGraphic(ellipse1);
            graphic2.AddGraphic(ellipse2);

            graphic.AddGraphic(graphic1);
            graphic.AddGraphic(graphic2);

            //Ако искаме да обходим трябва да имплементираме IEnumerable
            //foreach (var item in graphic)
            //{

            //}
        }
    }
}
