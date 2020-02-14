using System;
using System.Linq;
using SystemSplit.Contracts;
using SystemSplit.Models;
using System.Collections.Generic;
using SystemSplit.Models.Factories;
using SystemSplit.Core;

namespace SystemSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Run();

        }
    }
}
