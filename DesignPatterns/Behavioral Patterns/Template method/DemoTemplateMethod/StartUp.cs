using System;

namespace DemoTemplateMethod
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Bread sourdough = new Sourdough();
            sourdough.Make();

            Bread twelveGrain = new TwelveGrain();
            twelveGrain.Make();
        }
    }
}
