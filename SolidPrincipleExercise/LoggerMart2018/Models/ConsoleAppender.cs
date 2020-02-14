using System;
using LoggerMart2018.Models.Contracts;

namespace LoggerMart2018.Models
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout, ErrorLevel level)
        {
            this.Layout = layout;
            this.Level = level;
        }
        public ILayout Layout { get; }
        public ErrorLevel Level { get; }

        public void AppendMessage(IError error)
        {
            string formattedError = this.Layout.FormatError(error);
            Console.WriteLine(formattedError);

        }
    }
}
