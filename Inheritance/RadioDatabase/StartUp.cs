using System;

namespace RadioDatabase
{
    class StartUp
    {
        static void Main(string[] args)
        {            
            Core.Engine eng = new Core.Engine();
            eng.Run();
        }
    }
}
