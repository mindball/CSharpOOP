using System;
using System.Collections;
using System.Collections.Generic;

//IEnumerable provides an abstraction for looping over elements. It provides foreach-loop support. 
//And it allows us to use LINQ extensions.
//Class that implement  IEnumerable can be used in foreach loop
/// <summary>
///     Extensions. Consider this. If a method needs to be implemented for every kind of 
///     List and Array (such as string lists, string arrays, int lists), our program will grow.
//      But if a single extension method, one receiving IEnumerable, can be implemented, our code base remains smaller.
/// </summary>
namespace IEnumerable_IEnumerator
{
    class IEnumerable_IEnumerator
    {
        static void Main(string[] args)
        {
            Test obj = new Test(
                new string[] {"a", "b", "c", "d" });
            
            foreach (var item in obj)
            {
                Console.WriteLine(item);
            }

            //very quick way of implementing the iterator pattern
            YieldKeyword keyWord = new YieldKeyword();
            foreach (var item in keyWord.Power(2, 12))
            {
                Console.Write($"{item} ");
            }
        }
    }

    class Test : IEnumerable<string>
    {
        

        public Test(string[] elements)
        {
            this.Elements = new List<string>(elements);
        }

        IEnumerator<string> IEnumerable<string>.GetEnumerator()
        {
            Console.WriteLine("Start here");
            return this.Elements.GetEnumerator();
        }

        public List<string> Elements { get; set; }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Elements.GetEnumerator();
        }
    }

}
