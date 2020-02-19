using Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var builder = new FerrariBuilder();
            var director = new SportsCarBuildDirector(builder);

            director.Construct();
            Car myRaceCar = builder.GetResult();
        }
    }
}
