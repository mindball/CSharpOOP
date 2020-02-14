using System;
using System.Collections.Generic;


namespace LoggerMyversion.Core
{
    using LoggerMyversion.Models.Contracts;
    using LoggerMyversion.Models.Factories;

    public class Engine
    {
        private ILogger logger;
        private ErrorFactory errorFactory;
        public Engine(ILogger logger)
        {
            this.logger = logger;
            this.errorFactory = new ErrorFactory();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while(!input.Equals("END"))
            {
                string[] inputArgs = input.Split('|');
                string levelError = inputArgs[0];
                string dateTimeStr = inputArgs[1];
                string message = inputArgs[2];
                               
                IError error = this.errorFactory.CreateError(message, dateTimeStr, levelError);
                this.logger.Log(error);

                input = Console.ReadLine();
            }

            Console.WriteLine("Logger info");
            foreach (IAppender appender in this.logger.Appenders)
            {
                Console.WriteLine(appender);
            }
        }
    }
}
