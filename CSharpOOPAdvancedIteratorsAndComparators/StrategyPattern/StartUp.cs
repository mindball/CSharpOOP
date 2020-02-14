using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class StartUp
    {
        static void Main(string[] args)
        {
            SortedSet<Person> sortPersonByName = new SortedSet<Person>(new NameComparer());
            SortedSet<Person> sortPersonByAge = new SortedSet<Person>(new AgeComparer());

            int numberOfPerson = int.Parse(Console.ReadLine());
            while(numberOfPerson > 0)
            {
                string personNameWithAge = Console.ReadLine();
                string personName = personNameWithAge.Split()[0];
                int personAge = int.Parse(personNameWithAge.Split()[1]);

                sortPersonByName.Add(new Person(personName, personAge));
                sortPersonByAge.Add(new Person(personName, personAge));


                numberOfPerson--;
            }

            foreach (var person in sortPersonByName)
            {
                Console.WriteLine(person);
            }

            foreach (var person in sortPersonByAge)
            {
                Console.WriteLine(person);
            }

        }
    }
}
