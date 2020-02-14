using System;

namespace Attributes
{
    [Flags]
    //Flags attribute довежда enum до бит-маски
    enum FlagAttribute
    {
        None = 0,
        Cached = 1,
        Current = 2,
        Obsolete = 4
    }
}
