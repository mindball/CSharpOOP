using System;

namespace InterfaceSegragation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Буквално означава не правете голями интерфейси:
            //  - Prefer small, cohesive (lean and focused) interfaces
            //  - Divide "fat" interfaces into "role" interfaces
            /* "Clients should not be forced to depend
                on methods they do not use."
                    - Agile Principles, Patterns and Practices in C#
            **/


            Console.WriteLine("Hello World!");
        }
    }
}
