﻿using System.Collections.Generic;
using System.Text;
using Logger.Models.Contracts;

namespace Logger.Models.Loggers
{
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
            foreach (var appender in this.Appenders)
            {
                if(appender.Level <= error.Level)
                {
                    appender.Append(error);
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Logger info");

            foreach (var appender in Appenders)
            {
                sb.AppendLine(appender.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
