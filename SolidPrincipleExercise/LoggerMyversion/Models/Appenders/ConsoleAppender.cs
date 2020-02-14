using System;

namespace LoggerMyversion.Models.Appenders
{
    using LoggerMyversion.Models.Contracts;
    using LoggerMyversion.Models.Enums;

    public class ConsoleAppender : IAppender
    {
        private int countAppendedMsg = 0;
        public ConsoleAppender(ILayout layout, LevelError level)
        {
            this.Layout = layout;
            this.LevelError = level;
        }
        public ILayout Layout { get; }
        public LevelError LevelError { get; }
        

        public void Append(IError error)
        {
            string appendedMessage = this.Layout.FormatError(error);
            Console.WriteLine(appendedMessage);
            this.countAppendedMsg++;
        }

        public override string ToString()
        {
            string appenderType = this.GetType().Name;
            string layoutType = this.Layout.GetType().Name;
            string levelType = this.LevelError.ToString();


            string result = $"Appender type: {appenderType}," +
                $" Layout type: {layoutType}," +
                $" Report level: {levelType}," +
                $" Messages appended:" +
                $" {this.countAppendedMsg}";

            return result;
        }
    }
}
