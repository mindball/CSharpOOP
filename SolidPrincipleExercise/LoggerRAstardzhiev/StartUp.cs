using System;

namespace LoggerRAstardzhiev
{
    using Controllers;

    class StartUp
    {        
        static void Main(string[] args)
        {
            var simpleCodeManualTester = new SimpleCodeManualTester();
            simpleCodeManualTester.FirstSample();
            simpleCodeManualTester.Implementations();
            simpleCodeManualTester.Extensibility();
            simpleCodeManualTester.ReportThreshold();

            var controller = new Controller();
            controller.GetAppendersFromConsole();
            controller.ExecuteCommands();
            controller.PrintAppenders();
        }
    }
}
