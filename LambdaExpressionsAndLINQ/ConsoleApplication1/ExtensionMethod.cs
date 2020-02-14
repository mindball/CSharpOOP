using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public static class StringExtensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?', '!' },
                  StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    public static class IListExtensions
    {
        public static void IncreaseWidth(
              this IList<int> list, int amount)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] += amount;
            }
        }
    }

    public static class IEnumerableExtensions

    {

        public static string ToString<T>(
              this IEnumerable<T> enumeration)
        {
            StringBuilder result = new StringBuilder();
            result.Append("[");

            foreach (var item in enumeration)
            {
                result.Append(item.ToString());
                result.Append(", ");
            }
            if (result.Length > 1)
                result.Remove(result.Length - 2, 2);
            result.Append("]");

            return result.ToString();

        }

    }
    class ExtensionMethod
    {
        static void Main(string[] args)
        {
            //StringExtension
            string helloString = "Hello, Extension Methods!";
            int result = helloString.WordCount();

            Console.WriteLine(result);

            //Extension over Interface
            List<int> list = new List<int>() {1, 2,3,4,5 };
            Console.WriteLine(list.ToString<int>());
            list.IncreaseWidth(5);
            Console.WriteLine(list.ToString<int>());

        }
    }
}
