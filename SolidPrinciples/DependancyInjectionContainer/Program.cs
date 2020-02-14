using System;

namespace DependancyInjectionContainer
{
    class Program
    {
        /*
         * IoC Service lifetimes:
         *      Transient: the service is created each time it is requested
         *      Singleton: created once for the lifetime of the application
         *      Scoped: created once per request
         *  Benefit of the container: lifestyle management
         * 
         * 
         * 
         * 
         * 
         * 
         * */
        static void Main(string[] args)
        {
            CastleWindsorIoC newObj = new CastleWindsorIoC();

        }
    }
}
