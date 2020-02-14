using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        ReflectionTest.id = 1;
        ReflectionTest.fName = "Test of reflection";
        ReflectionTest.attr = new List<string>() { "asd", "bsd" };
        ReflectionTest.Write();
    }
}

class ReflectionTest
{
    public static int id;
    public static string fName;   
    public static List<string> attr;

    public static void Write()
    {
        Type type = typeof(ReflectionTest);
        FieldInfo[] fields = type.GetFields();
        foreach (var field in fields)
        {
            string name = field.Name;
            object temp = field.GetValue(null);
            if (temp is int) // See if it is an integer.
            {
                int value = (int)temp;
                Console.Write(name);
                Console.Write(" (int) = ");
                Console.WriteLine(value);
            }
            else if (temp is string) // See if it is a string.
            {
                string value = temp as string;
                Console.Write(name);
                Console.Write(" (string) = ");
                Console.WriteLine(value);
            }
            else if(temp == typeof(List<>))
            {
                Console.WriteLine("asdasda");
            }
        }
    }
}

