using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPatternLazyImplementationExampleCSharpInDepth
{
    public sealed class Singleton
    {

        //https://csharpindepth.com/articles/singleton#lazy
        /*
         * 
         * It's simple and performs well. It also allows you to check whether or not the instance
         * has been created yet with the IsValueCreated property.
         * 
         * */
        private static readonly Lazy<Singleton> lazy =
            new Lazy<Singleton>(() => new Singleton());

        private Singleton()
        {
        }
        public static Singleton Instance { get { return lazy.Value; } }
    }
}
