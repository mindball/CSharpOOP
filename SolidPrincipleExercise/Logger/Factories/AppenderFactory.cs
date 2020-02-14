using System;

using Logger.Exceptions;
using Logger.Models.Appender;
using Logger.Models.Contracts;
using Logger.Models.Enumeration;
using Logger.Models.Files;

namespace Logger.Factories
{
    public class AppenderFactory
    {
        private LayoutFactory layoutFactory;
        public AppenderFactory()
        {
            this.layoutFactory = new LayoutFactory();
        }
        public IAppender GetAppender(string appenderType, string layoutType,
            string levelStr)
        {
            ILayout layout = this.layoutFactory.GetLayout(layoutType);

            Level level;
            bool levelHasParse = Enum.TryParse<Level>(levelStr, out level);
            if(!levelHasParse)
            {
                throw new InvalidLevelTypeException();
            }

            IAppender appender;
            if(appenderType.Equals("ConsoleAppender"))
            {
                appender = new ConsoleAppender(layout, level);
            }
            else if (appenderType.Equals("FileAppender"))
            {
                IFile file = new LogFile();
                appender = new FileAppender(layout, level, file);
            }
            else
            {
                throw new InvalidAppenderTypeException();
            }

            return appender;
        }
    }
}
