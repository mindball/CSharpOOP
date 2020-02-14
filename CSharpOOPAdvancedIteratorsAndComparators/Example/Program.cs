using System;
using System.Collections.Generic;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> oldYears = new List<int>()
            {
                1990,
                1991,                
                2001,
                2002               
            };

            IEnumerable<int> parseOldYearsToEnumerable = (IEnumerable<int>)oldYears;
            //IEnumerable is the generic interface available for collection type objects and by implementing the IEnumerable interface,
            //a generic class essentially enables iteration via the IEnumerator interface. It uses only one method GetEnumerator that
            //returns an enumerator class instance that implement IEnumerator interface
            PrintYearByIEnumerableTo2000(parseOldYearsToEnumerable);


            IEnumerator<int> parseOldYearsToEnumerator = oldYears.GetEnumerator();
            PrintYearByIEnumeratorTo2000(parseOldYearsToEnumerator);
            
            //IEnumerator remembers states while IEnumerable does not

            /*
             * Така че зависи от нашето условие. Ако искаме да изреждаме списък (или която и да е колекция),
             * тогава IEnumerable е най-добрият избор, но ако искаме да запазим състоянието (т.е. докъде сме стигнали),
             * тогава трябва да продължим с IEnumerator.
             * */           
            //IEnumerator interface is meant to be used as accessors and it cannot be used to modify the underlying collection.
            //It provides two abstract methods Reset ( ) and MoveNext ( ), and a property Current to call a particular element in a collection.

    }

    static void PrintYearByIEnumerableTo2000(IEnumerable<int> parseOldYears)
        {
            foreach (var year in parseOldYears)
            {
                if (year > 2000)
                    PrintYearByIEnumerableAfter2000(parseOldYears);

                Console.WriteLine(year);
            }
        }

        static void PrintYearByIEnumerableAfter2000(IEnumerable<int> parseOldYears)
        {
            Console.WriteLine();
            foreach (var year in parseOldYears)
            {
                Console.WriteLine(year);
            }
        }

        static void PrintYearByIEnumeratorTo2000(IEnumerator<int> parseOldYears)
        {
            Console.WriteLine("IEnumeratorTo2000");
            while(parseOldYears.MoveNext())
            {
                Console.WriteLine(parseOldYears.Current);
                if (parseOldYears.Current > 2000)
                    PrintYearByIEnumeratorAfter2000(parseOldYears);

            }
        }

        static void PrintYearByIEnumeratorAfter2000(IEnumerator<int> parseOldYears)
        {
            Console.WriteLine("IEnumeratorAfter2000");


            while (parseOldYears.MoveNext())
            {
                Console.WriteLine(parseOldYears.Current);
            }
        }
    }
}
