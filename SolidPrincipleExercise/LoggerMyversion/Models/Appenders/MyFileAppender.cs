using LoggerMyversion.Models.Contracts;
using LoggerMyversion.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerMyversion.Models.Appenders
{
    class MyFileAppender : IAppender
    {
        private int countAppendedMsg = 0;
        
        public MyFileAppender(ILayout layout, LevelError levelError, IMyLogFile myLogFile)
        {
            this.Layout = layout;
            this.LevelError = LevelError;
            this.MyLogFile = myLogFile;
        }
        public ILayout Layout { get; }
        public LevelError LevelError { get; }

        IMyLogFile MyLogFile { get; }

        public void Append(IError error)
        {
            string appendedMessage = this.Layout.FormatError(error);
            this.MyLogFile.WriteMyLogFile(appendedMessage);
            this.countAppendedMsg++;
        }

        public override string ToString()
        {
            string appenderType = this.GetType().Name;
            string layoutType = this.Layout.GetType().Name;
            string levelType = this.LevelError.ToString();
            int sizeFile = this.MyLogFile.Size;

            return $"Appender type: {appenderType}," +
                $" Layout type: {layoutType}," +
                $" Report level: {levelType}, " +
                $"Messages appended: {this.countAppendedMsg}, " +
                $"File size: {sizeFile}";
        }
    }
}
