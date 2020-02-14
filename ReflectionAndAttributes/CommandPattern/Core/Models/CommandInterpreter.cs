using CommandPattern.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern.Core.Models
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private const string Command_Postfix = "Command";
      
        public string Read(string args)
        {
            string[] tokens = args.Split(" ", 
                System.StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string commandName = tokens[0] + Command_Postfix;
            string[] commandsArgs = tokens.Skip(1).ToArray();

            var assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();
            Type type = types.FirstOrDefault(x => x.Name == commandName);
            var objType = Activator.CreateInstance(type);
            ICommand command = (ICommand)objType;

            string result = command.Execute(commandsArgs);
                        
            return result;
        }
    }
}
