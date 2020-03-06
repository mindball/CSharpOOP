using System;

namespace ChainPatternWikiExample
{
    public class ConsoleLogger : Logger
    {
        public ConsoleLogger(LogLevel level)
            : base(level)
        {
        }

        protected override void WriteMessage(string msg)
        {
            Console.WriteLine("Writing on the console: " + msg);
        }
    }
}
