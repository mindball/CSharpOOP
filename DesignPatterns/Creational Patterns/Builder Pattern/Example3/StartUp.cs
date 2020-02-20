//Get -> https://www.codeproject.com/Articles/1156619/Builder-Design-Pattern-with-Demo
using Example3.Models;

namespace Example3
{
    class StartUp
    {
        static void Main(string[] args)
        {
            BicycleBuildDirector buildDirector = new BicycleBuildDirector();
            Bicycle bicycle = buildDirector.Construct(new KidsBicycleBuilder(), "Red", 16);
        }
    }
}
