using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPatternLazyImplementationExampleCSharpInDepth
{
    public sealed class LazySingletonImplementation
    {
        private static readonly Lazy<LazySingletonImplementation> lazy =
            new Lazy<LazySingletonImplementation>(() => new LazySingletonImplementation());

        private LazySingletonImplementation()
        {
        }

        public static LazySingletonImplementation Instance { get { return lazy.Value; } }
    }
}
