using ExplicitInterfaces.Models;
using ExplicitInterfaces.Contracts;
using System;

namespace ExplicitInterfaces
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            
            while(!input.Equals("End"))
            {
                string[] paramsArg = input.Split();
                string name = paramsArg[0];
                string country = paramsArg[1];
                int age = int.Parse(paramsArg[2]);

                Citizen citizen = new Citizen(name, country, age);
                Console.WriteLine(citizen.GetName());
                Console.WriteLine(((IResindent)citizen).GetName());

                input = Console.ReadLine();
            }
        }
    }
}
