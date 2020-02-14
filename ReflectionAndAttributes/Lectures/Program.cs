using System;
using System.Reflection;

namespace Lectures
{
    class Program
    {
        /*
         * Type e = typeof(Program);
         * var @единственоЧисло = e.GetInterface("нещо си");
         * Когато е в единствено число, връща конкретно нещо или null ако 
         * не го е намерил - > задължителна проверка за null
         * Aко е множествено число
         * var @множественоЧисло = e.GetInterfaces();
         * връща колекция и тук проверяваме за дължината на колекциятa
         * а не за null lenght > 0 
         * 
         * Когато имаме статично поле или пропери или метод, когато го достъпваме
         * чрез reflection със SetValue и GetValue, тези методи искат
         * инстанция и вместо да я въведем слагаме null вместо инстация !!!
         * 
         *  Assemblies contain modules
         *  Modules contain types
         *  Types contain members
         * 
         * System.Reflection: Get 'this' assembly
         * The Get*Assembly methods in the System.Reflection.Assembly namespace do add a bit of confusion as their description is usually quite brief. In this blog post, I'll add a bit more verbosity by going over some of the possible scenarios... here's the GetEntryAssembly vs GetExecutingAssembly vs GetCallingAssembly.

            GetEntryAssembly
            This method gets the assembly that started the process, pretty much what started
            the whole chain reaction and the reason why the CPU is looking at the bit of code
            you've written to make this call.            
            Suppose you've got a ConsoleApplication1.exe assembly that you double-click on to run,
            that's the entry assembly - it's as simple as that!
            
            GetExecutingAssembly            
            In most large applications, you'll be writing your code as separate modules and would
            probably have a library of common structures and functions that you would need to access
            from each of the modules. The GetExecutingAssembly is like a 'Who Am I' for the code to
            tell which assembly is located in.            
            Let's say our ConsoleApplication1.exe makes a call to ClassLibrary1.dll. Now, 
            if we were to call GetExecutingAssembly from within a method in ClassLibrary1.dll
            which in turn is called by a method in ConsoleApplication1.exe, we would get ClassLibrary1
            as the executing assembly because that's where the exact code "Assembly.GetExecutingAssembly()" appears.
            
            GetCallingAssembly            
            This gets a *little more* complicated here, but it's still simple enough for
            you to get with half a brain cell. If you were to look at the stack trace and take one
            step back from the current method, that's the calling method and wherever it is located
            is called the calling assembly.
            GetCallingAssembly: to get the assembly one level up the call stack, i.e. which contains the method the current executing code

            Let's take 2 scenarios here as this takes a little more explaining.            
            Scenario 1 (GetCallingAssembly): Let's take the case of ConsoleApplication1 calling a
            method in ClassLibrary1. GetCallingAssembly would give you ConsoleApplication1.            
            Scenario 2 (GetCallingAssembly): Suppose ConsoleApplication1 calls a method in ClassLibrary1, which calls another method in ClassLibrary1. GetCallingAssembly now gives you ClassLibrary1.
         * 
         *  
         *  GetEntryAssembly: to get the assembly which contains the entry point to the application, e.g. the Main method in a Console app
         *  GetExecutingAssembly: to get the assembly of the currently running code
         * 
         * */
        static void Main(string[] args)
        {
            Type e = typeof(Program);
            var @единственоЧисло = e.GetInterface("нещо си");
            var @множественоЧисло = e.GetInterfaces();

            var t = Assembly.LoadFile(@"./OtherReflectionsExample.dll");
            




        }
    }
}
