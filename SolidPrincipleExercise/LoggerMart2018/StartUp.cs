using System;
using System.Collections.Generic;

using LoggerMart2018.Core;
using LoggerMart2018.Models;
using LoggerMart2018.Models.Contracts;
using LoggerMart2018.Models.Factories;

namespace LoggerMart2018
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ILogger logger = InitializeLogger();
            ErrorFactory errorFactory = new ErrorFactory();
            Engine engine = new Engine(logger, errorFactory);

            engine.Run();

        }

        static ILogger InitializeLogger()
        {
            ICollection<IAppender> appenders = new List<IAppender>();
            //TODO Factory
            LayoutFactory layoutFactory = new LayoutFactory();
            AppenderFactory appenderFactory = new AppenderFactory(layoutFactory);

            int appenderCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < appenderCount; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();
                string appenderType = inputArgs[0];
                string layoutType = inputArgs[1];
                string errorLevel = "INFO";

                if(inputArgs.Length == 3)
                    errorLevel = inputArgs[2];

                IAppender appender = appenderFactory.
                    CreateAppender(appenderType, errorLevel, layoutType);

                appenders.Add(appender);
            }

            return new Logger(appenders);
        }
    }
}
