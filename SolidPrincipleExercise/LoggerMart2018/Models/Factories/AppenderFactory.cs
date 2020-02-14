using System;

using LoggerMart2018.Models.Contracts;

namespace LoggerMart2018.Models.Factories
{
    public class AppenderFactory
    {
        private LayoutFactory layoutFactory;

        public AppenderFactory(LayoutFactory layoutFactory)
        {
            this.layoutFactory = layoutFactory;
        }

        public IAppender CreateAppender(string appenderType, 
            string level, 
            string layoutType)
        {
            ILayout layout = this.layoutFactory.CreateLayout(layoutType);
            ErrorLevel errorLevel = this.ParseErrorLevel(level);

            switch(appenderType)
            {
                case "ConsoleAppender":
                    return new ConsoleAppender(layout, errorLevel);
                    break;
                default:
                    throw new ArgumentException("Invalid Appende type!!!");
            }
        }

        private ErrorLevel ParseErrorLevel(string level)
        {
            try
            {
                object levelObj = Enum.Parse(typeof(ErrorLevel), level);

                return (ErrorLevel)levelObj;
            }
            catch(ArgumentException e)
            {
                throw new ArgumentException("Invalid ErrorLevel Type!!!", e);
            } 
        }
    }
}
