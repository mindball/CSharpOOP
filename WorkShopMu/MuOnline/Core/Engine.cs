namespace MuOnline.Core
{
    using System;
    using Microsoft.Extensions.DependencyInjection;

    using Contracts;

    public class Engine : IEngine
    {
        private readonly IServiceProvider serviceProvider;

        public Engine(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void Run()
        {
            string[] input = Console.ReadLine()
                         .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (true)
            {
                try
                {                    
                    var commandInterpretator = serviceProvider.GetService<ICommandInterpreter>();
                    var result = commandInterpretator.Read(input);

                    //TODO add IWriter
                    Console.WriteLine(result);
                }
                //best practise : have hierarchy exception
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine(ane.Message);
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }

                input = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }
           
        }
    }
}
