using System;
using ValidatorExample.Exception;
using ValidatorExample.Models;

namespace ValidatorExample
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Person[] persons = {
                new Person() { Name = "DrunkedMaster17t", Age = 17, ConsumesAlcohol = true },
                new Person() { Name = "DrunkedMaster18t", Age = 18, ConsumesAlcohol = true },
                new Person() { Name = "DrunkedMaster0t", Age = 0, ConsumesAlcohol = true },
                new Person() { Name = "DrunkedMaster-1t", Age = -1, ConsumesAlcohol = true },
                new Person() { Name = "DrunkedMaster17f",Age = 18, ConsumesAlcohol = false },
                new Person() { Name = "DrunkedMaster18f",Age = 17, ConsumesAlcohol = false },
                new Person() { Name = "DrunkedMaster0f",Age = 0, ConsumesAlcohol = false },
                new Person() { Name = "DrunkedMaster-1f",Age = -1, ConsumesAlcohol = false }
            };

            foreach (var person in persons)
            {
                try
                {
                    var validationDrunk = new OnlyAdultsCanConsumeAlcoholValidation(person);
                    var validationAge = new Age0OrHigherValidation(person);
                    validationAge.Validate();
                    validationDrunk.Validate();
                    
                }
                catch (ValidationException ve)
                {
                    Console.WriteLine(ve.Message);
                }
            }
        }

    }
}
