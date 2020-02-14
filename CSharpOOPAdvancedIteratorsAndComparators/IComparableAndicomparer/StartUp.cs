using System;
using System.Collections.Generic;

namespace IComparableAndicomparer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //IComparable
            //Provides a method of comparing two objects of a particular type – CompareTo()
            //Sets a default sort order for the particular objects type
            //Affects original class
            //Affects original class
            //Affects original class

            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { Name = "Steve", Salary = 10000 });
            list.Add(new Employee() { Name = "Janet", Salary = 10000 });
            list.Add(new Employee() { Name = "Andrew", Salary = 10000 });
            list.Add(new Employee() { Name = "Bill", Salary = 500000 });
            list.Add(new Employee() { Name = "Lucy", Salary = 8000 });

            // Uses IComparable.CompareTo()
            list.Sort();

            // Uses Employee.ToString
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }


            //IComparer
            //Provides a way to customize the sort order of a collection
            //Defines a method that a type implements to compare two objects
            //Doesn’t affect original class
            //Doesn’t affect original class
            //Doesn’t affect original class

            List<Dwarf> sevenDwarfs = new List<Dwarf>();
            sevenDwarfs.Add(new Dwarf() { name = "Sleepy", id = 3 });
            sevenDwarfs.Add(new Dwarf() { name = "Bashful", id = 1 });
            sevenDwarfs.Add(new Dwarf() { name = "Doc", id = 6 });
            sevenDwarfs.Add(new Dwarf() { name = "Dopey", id = 4 });
            sevenDwarfs.Add(new Dwarf() { name = "Happy", id = 5 });
            sevenDwarfs.Add(new Dwarf() { name = "Sneezy", id = 2 });
            sevenDwarfs.Add(new Dwarf() { name = "Grumpy", id = 7 });

            DwarfComparer dc = new DwarfComparer();
            sevenDwarfs.Sort(dc);

            foreach (var item in sevenDwarfs)
            {
                Console.WriteLine(item.name + " " + item.id);
            }

        }
    }
}
