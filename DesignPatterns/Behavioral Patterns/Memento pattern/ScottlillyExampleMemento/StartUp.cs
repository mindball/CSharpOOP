using System;

namespace ScottlillyExampleMemento
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CustomerMultipleMemento test = new CustomerMultipleMemento(0, "Ivans Krotev", "c. Asen", "Pavel Banya", "Stara Zagora", "6545");
            test.Address = "Gorno novo selo";

            test.ReverToLastValues();
        }
    }
}
