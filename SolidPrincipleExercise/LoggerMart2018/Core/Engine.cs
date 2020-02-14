using System;

using LoggerMart2018.Models;
using LoggerMart2018.Models.Contracts;
using LoggerMart2018.Models.Factories;

namespace LoggerMart2018.Core
{
    public class Engine
    {
        private ILogger logger;
        private ErrorFactory errorFactory; 
        public Engine(ILogger logger, ErrorFactory errorFactory)
        {
            this.logger = logger;
            this.errorFactory = new ErrorFactory();
        }

        public void Run()
        {
            string input;
            while(!(input = Console.ReadLine()).Equals("END"))
            {
                string[] errorArg = input.Split('|');
                string level = errorArg[0];
                string dateTime = errorArg[1];
                string message = errorArg[2];

                IError error = this.errorFactory
                    .CreateError(dateTime, level, message);

                this.logger.Log(error);
            }
        }
    }
}
