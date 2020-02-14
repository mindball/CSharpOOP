using System;
using System.Collections.Generic;
using System.Linq;
using Logger.Core;
using Logger.Factories;
using Logger.Models.Contracts;
using Logger.Models.Loggers;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            int appendersCount = int.Parse(Console.ReadLine());

            ICollection<IAppender> appenders = new List<IAppender>();
            AppenderFactory appenderFactory = new AppenderFactory();

            //dependency inversion -> AppenderFactory appenderFactory;
            ReadAppendersData(appendersCount, appenders, appenderFactory);
            //namespace conflicts
            ILogger logger = new Logger.Models.Loggers.Logger(appenders);

            Engine engine = new Engine(logger);
            engine.Run();
        }

        private static void ReadAppendersData(int appendersCount,
            ICollection<IAppender> appenders,
            AppenderFactory appenderFactory)
        {
            for (int i = 0; i < appendersCount; i++)
            {
                string[] appenderInfo = Console.ReadLine()
                    .Split(" ")
                    .ToArray();

                string appenderType = appenderInfo[0];
                string layoutType = appenderInfo[1];

                string levelStr = null;
                if (appenderInfo.Length == 3)
                {
                    levelStr = appenderInfo[2];
                }

                
                try
                {
                    IAppender appender = appenderFactory.GetAppender(appenderType,
                    layoutType, levelStr);

                    appenders.Add(appender);
                }
                catch(Exception ex)
                {
                    //Output needed?
                    Console.WriteLine(ex.Message);
                    //countinue;
                }

                
            }
        }
    }
}
