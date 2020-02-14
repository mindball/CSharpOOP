using System;

namespace P01.HelloWorldAfter
{
    class Program
    {
        static void Main(string[] args)
        {
            var greeting = new HelloWorld();
            //ако е както before трудно ще му пуснем тест за промянаа на времето
            greeting.Greeting("pesho", DateTime.Now);
        }

        [TestMethod]
        public static void Test()
        {
            var greeting = new HelloWorld();
            greeting.Greeting("pesho", dateInTwelveAClock());
            greeting.Greeting("pesho", dateInElevenAClock());
        }

        private static DateTime dateInTwelveAClock()
        {
            //връща 12 часа
            return new DateTime();
        }

        private static DateTime dateInElevenAClock()
        {
            //връща 11 часа
            return new DateTime();
        }


    }
}
