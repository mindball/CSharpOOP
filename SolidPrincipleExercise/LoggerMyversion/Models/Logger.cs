using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerMyversion.Models
{
    using LoggerMyversion.Models.Contracts;

    public class Logger : ILogger
    {
        private ICollection<IAppender> appenders;
        public Logger(ICollection<IAppender> appenders)
        {
            this.appenders = appenders;
        }
        public IReadOnlyCollection<IAppender> Appenders =>
            (IReadOnlyCollection<IAppender>)this.appenders;

        public void Log(IError error)
        {
            foreach (var appender in this.appenders)
            {
                if (appender.LevelError <= error.LevelError)
                    appender.Append(error);
            }
        }
    }
}
