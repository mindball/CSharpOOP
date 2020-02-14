using System;

namespace LoggerMyversion.Models
{
    using LoggerMyversion.Models.Contracts;
    using LoggerMyversion.Models.Enums;

    public class Error : IError
    {
        public Error(string message, DateTime dateTime, LevelError levelError)
        {
            this.Message = message;
            this.DateTime = dateTime;
            this.LevelError = levelError;
        }

        public string Message { get; }
        public DateTime DateTime { get; }
        public LevelError LevelError { get; }
    }
}
