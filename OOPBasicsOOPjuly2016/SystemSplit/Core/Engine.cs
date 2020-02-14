using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Text;

using SystemSplit.Contracts;
using SystemSplit.Models;
using SystemSplit.Models.Factories;

namespace SystemSplit.Core
{
    public class Engine
    {
        private IList<IComponentHardware> hardwareComponents;
        private HardwareFactory hardwareFactory;
        private SoftwareFactory softwareFactory;
        private Machine newMachine;

        public Engine()
        {
            this.hardwareComponents = new List<IComponentHardware>();
            hardwareFactory = new HardwareFactory();
            softwareFactory = new SoftwareFactory();
            newMachine = new Machine();
        }

        public void Run()
        {
            string input = Console.ReadLine();
            while (!input.Equals("System Split"))
            {
                string command = CapitalSplit(input);
                int startIndexOfNextArgument = command.Length;
                CommandInterpreter(command, input.Substring(startIndexOfNextArgument));

                string component = CapitalSplit(input.Substring(startIndexOfNextArgument));
                startIndexOfNextArgument += component.Length;



                input = Console.ReadLine();
            }

            this.newMachine.SystemSplit();
        }

        private void CommandInterpreter(string command, string component)
        {
            switch (command)
            {
                case "Register":
                    this.RegisterComponent(component);
                    break;
                case "Analyze":
                    this.Analyze();
                    break;
                case "Release":
                    this.ReleaseComponet(component);
                    break;                
            }
        }

        private string CapitalSplit(string str)
        {
            StringBuilder result = new StringBuilder();
            bool isFindCappitalLetter = false;

            foreach (char c in str)
            {
                if (char.IsUpper(c) && !isFindCappitalLetter)
                {
                    result.Append(c);
                    isFindCappitalLetter = true;
                }
                else if (!char.IsUpper(c) && char.IsLetter(c))
                    result.Append(c);
                else
                    break;
            }

            return result.ToString();
        }

        private string[] SplitByMultipleChars(string str)
        {
            string[] arrStr =
                str.Split(new string[] { "(", ",", ")" }, StringSplitOptions.RemoveEmptyEntries);
            return arrStr;
        }

        private void RegisterComponent(string component)
        {
            int startIndexOfComponentArguments = component.IndexOf('(');
            string typeComponent = component.Substring(0, startIndexOfComponentArguments);

            string[] componentArguments = SplitByMultipleChars(
                component.Substring(startIndexOfComponentArguments));

            if(typeComponent.Contains("Hardware"))
            {
                IComponentHardware newHardware =  hardwareFactory.CreateHardware(
                    typeComponent, componentArguments[0],
                    int.Parse(componentArguments[1]),
                    int.Parse(componentArguments[2]));

                this.newMachine.AddHardwareItem(newHardware);
            }
            else
            {
                IComponentSoftware newSoftware =  softwareFactory.CreateSoftware(typeComponent,
                    componentArguments[1],
                    int.Parse(componentArguments[2]),
                    int.Parse(componentArguments[3]));

                this.newMachine.AddSoftwareItem(componentArguments[0], newSoftware);
            }

           
        }

        private void ReleaseComponet(string component)
        {
            int startIndexOfComponentArguments = component.IndexOf('(');
            string typeComponent = component.Substring(0, startIndexOfComponentArguments);

            string[] componentArguments = SplitByMultipleChars(
                component.Substring(startIndexOfComponentArguments));

            this.newMachine.ReleaseSoftwareComponent(componentArguments[0],
                componentArguments[1]);

        }

        private void Analyze()
        {
            this.newMachine.Analyze();
        }

    }
}
