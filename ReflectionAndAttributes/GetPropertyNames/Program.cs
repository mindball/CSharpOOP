using System;
using System.Reflection;
using System.Linq;

namespace OtherReflectionsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            GetPropertyInfo();

            var ExecuteAssembly = Assembly.GetExecutingAssembly();
            var entryAssebly = Assembly.GetEntryAssembly();
            var CallgetCallAss = Assembly.GetCallingAssembly();

            PropertyInfoExample p = new PropertyInfoExample();


            var types = ExecuteAssembly.GetTypes();

            foreach (var type in types)
            {
                var typeInfo = type.GetTypeInfo();
                Console.WriteLine("Type " + type.FullName + " has " + typeInfo.DeclaredProperties.Count().ToString() + " properties");
            }

            Type t = typeof(PropertyInfoExample);
            ConstructorInfo[] c = t.GetConstructors();

            ConstructorInfo constructor = t.GetConstructor(new[] { typeof(string)});
            

        }

        private static void GetPropertyInfo()
        {
            Type t = typeof(PropertyInfoExample);
            // Get the public properties.
            PropertyInfo[] propInfos = t.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine("The number of public properties: {0}.\n",
                              propInfos.Length);
            // Display the public properties.
            DisplayPropertyInfo(propInfos);

            // Get the nonpublic properties.
            PropertyInfo[] propInfos1 = t.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);
            Console.WriteLine("The number of non-public properties: {0}.\n",
                              propInfos1.Length);
            // Display all the nonpublic properties.
            DisplayPropertyInfo(propInfos1);
        }

        public static void DisplayPropertyInfo(PropertyInfo[] propInfos)
        {
            // Display information for all properties.
            foreach (var propInfo in propInfos)
            {
                bool readable = propInfo.CanRead;
                bool writable = propInfo.CanWrite;

                Console.WriteLine("   Property name: {0}", propInfo.Name);
                Console.WriteLine("   Property type: {0}", propInfo.PropertyType);
                Console.WriteLine("   Read-Write:    {0}", readable & writable);
                if (readable)
                {
                    MethodInfo getAccessor = propInfo.GetMethod;
                    Console.WriteLine("   Visibility:    {0}",
                                      GetVisibility(getAccessor));
                }
                if (writable)
                {
                    MethodInfo setAccessor = propInfo.SetMethod;
                    Console.WriteLine("   Visibility:    {0}",
                                      GetVisibility(setAccessor));
                }
                Console.WriteLine();
            }
        }

        public static String GetVisibility(MethodInfo accessor)
        {
            if (accessor.IsPublic)
                return "Public";
            else if (accessor.IsPrivate)
                return "Private";
            else if (accessor.IsFamily)
                return "Protected";
            else if (accessor.IsAssembly)
                return "Internal/Friend";
            else
                return "Protected Internal/Friend";
        }
    }
}

namespace University
{

    public class Student
    {
        public string FullName { get; set; }

        public int Class { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string GetCharacteristics()
        {
            return "";
        }
    }

    namespace Department
    {

        public class Professor
        {

            public string FullName { get; set; }

        }
    }
}
