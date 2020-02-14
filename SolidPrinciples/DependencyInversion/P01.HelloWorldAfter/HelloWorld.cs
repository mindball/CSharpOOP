using System;

namespace P01.HelloWorldAfter
{
    public class HelloWorld
    {
        //Вкарване на Dependecy със DateTime object
        public string Greeting(string name, 
            DateTime obj)
        {
            if (obj.Hour < 12)
            {
                return "Good morning, " + name;
            }

            if (obj.Hour < 18)
            {
                return "Good afternoon, " + name;
            }

            return "Good evening, " + name;
        }
    }
}
