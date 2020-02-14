using System;
using System.Collections.Generic;

namespace LoggerMyversion
{
    using LoggerMyversion.Core;
    using LoggerMyversion.Models;
    using LoggerMyversion.Models.Contracts;
    using LoggerMyversion.Models.Factories;

    class Program
    {

        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            ICollection<IAppender> appenders = new List<IAppender>();

            for (int i = 0; i < input; i++)
            {
                string[] inputArguments = Console.ReadLine().Split();

                string typeOfAppender = inputArguments[0];
                string typeOfLayout = inputArguments[1];

                string typeOfReportLevel = "INFO";
                if (inputArguments.Length == 3)
                {
                    typeOfReportLevel = inputArguments[2];
                }

                InitializeAppenders(appenders, typeOfAppender, typeOfLayout, typeOfReportLevel);
            }

            InitializeLogger(appenders);
        }

        private static void InitializeLogger(ICollection<IAppender> appenders)
        {
            //TODO Catch appender null exception
            ILogger logger = new Logger(appenders);
            Engine engine = new Engine(logger);

            engine.Run();

        }

        private static void InitializeAppenders(ICollection<IAppender> appenders, 
            string typeOfAppender,
            string typeOfLayout,
            string typeOfReportLevel)
        {    
            AppenderFactory appenderFactory = new AppenderFactory();
            IAppender appender = appenderFactory.CreateAppender(typeOfAppender,
                typeOfLayout, typeOfReportLevel);
            appenders.Add(appender);
        }
    }
}

