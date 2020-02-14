using LoggerMyversion.Models.Appenders;
using LoggerMyversion.Models.Contracts;
using LoggerMyversion.Models.Enums;
using System;

namespace LoggerMyversion.Models.Factories
{
    public class AppenderFactory
    {
        const string DefaultFileName = "logFile{0}.txt";

        private int fileNumber;
        private LayoutFactory layoutFactory;
        public AppenderFactory()
        {
            this.layoutFactory = new LayoutFactory();
            this.fileNumber = 0;
        }
        public IAppender CreateAppender(string appenderType, string layoutType, string levelErrorStr)
        {
            ILayout layout = this.layoutFactory.CreateLayout(layoutType);
            LevelError levelError = this.ParseErrorLevel(levelErrorStr);

            switch (appenderType)
            {
                case "ConsoleAppender":
                    return new ConsoleAppender(layout, levelError);
                    break;
                case "FileAppender":
                    ILogFile file = new LogFile(string.Format(DefaultFileName, this.fileNumber));
                    return new FileAppender(layout, levelError, file);
                    break;
                default:
                    throw new ArgumentException("Invalid Appender type!!!");
            }
        }

        private LevelError ParseErrorLevel(string level)
        {
            try
            {
                object levelObj = Enum.Parse(typeof(LevelError), level);

                return (LevelError)levelObj;
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException("Invalid LevelError Type!!!", e);
            }
        }
    }
}
