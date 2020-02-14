using System.Collections.Generic;
using LoggerMart2018.Models.Contracts;

namespace LoggerMart2018.Models
{
    public class Logger : ILogger
    {
        IEnumerable<IAppender> appenders;
        public Logger(IEnumerable<IAppender> appenders)
        {
            this.appenders = appenders;
        }
        public void Log(IError error)
        {
            foreach (IAppender appender in this.appenders)
            {
                if(appender.Level <= error.Level)
                {
                    appender.AppendMessage(error);
                }
            }
        }
    }
}
