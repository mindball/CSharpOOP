using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    static class MakeSubStringOnStringBuilder
    {
        public static StringBuilder SubString(this StringBuilder strBuild, int index, int len)
        {
            StringBuilder current = new StringBuilder();
            current.Append(strBuild.ToString(index, len));
            return current;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder test = new StringBuilder();
            test.Append("Quick Fox Brow Jump over the lazy Dog");
            test = test.SubString(10, 15);




        }
    }
}
