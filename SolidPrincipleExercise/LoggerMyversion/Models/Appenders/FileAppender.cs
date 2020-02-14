using LoggerMyversion.Models.Contracts;
using LoggerMyversion.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerMyversion.Models.Appenders
{
    class FileAppender : IAppender
    {
        private int countAppendedMsg = 0;
        private ILogFile logFile;
        public FileAppender(ILayout layout, LevelError level, ILogFile logFile)
        {
            this.Layout = layout;
            this.LevelError = level;
            this.logFile = logFile;

        }
        public ILayout Layout { get; }
        public LevelError LevelError { get; }

        public void Append(IError error)
        {
            string formmatedError = this.Layout.FormatError(error) + Environment.NewLine;
            this.logFile.WriteToFile(formmatedError);
            countAppendedMsg++;
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
                $" {this.countAppendedMsg}" +
                $" File size: {this.logFile.Size}";

            return result;
        }
    }
}
