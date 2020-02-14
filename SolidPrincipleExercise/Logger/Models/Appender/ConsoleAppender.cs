using System;
using System.Globalization;

using Logger.Models.Contracts;
using Logger.Models.Enumeration;

namespace Logger.Models.Appender
{
    public class ConsoleAppender : IAppender
    {
        private int messageAppend;
        private const string formatDateTime = @"M/dd/yyyy h:mm:ss tt";

        private ConsoleAppender()
        {
            this.messageAppend = 0;
        }
        public ConsoleAppender(ILayout layout, Level level)
                : this()
        {
            this.Layout = layout;
            this.Level = level; 
        }
        public ILayout Layout { get; }
        public Level Level { get; private set; }

        public void Append(IError error)
        {
            string format = this.Layout.Format;

            DateTime dateTime = error.DateTime;
            Level level = error.Level;
            string message = error.Message;

            string formattedMessage = String.Format(format,
                dateTime.ToString(formatDateTime, CultureInfo.InvariantCulture),
                level.ToString(),
                message);

            Console.WriteLine(formattedMessage);
            this.messageAppend++;
        }

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, " +
                $"Layout type: {this.Layout.GetType().Name}, " +
                $"Report level: {this.Level.ToString()}, " +
                $"Messages appended: {this.messageAppend}";
        }
    }
}
