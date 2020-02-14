using System;
using System.Collections.Generic;
using System.Text;

namespace Attributes
{
    [Flags]
    enum RenderType
    {
        None = 0x0,
        DataUri = 0x1,
        GZip = 0x2,
        ContentPage = 0x4,
        ViewPage = 0x8,
        HomePage = 0x10
    }
}
