namespace Lectures.ObserverDesignPattern
{
    using System;
    public class ConsoleWriteLinePersonObserver : IPersonObserver
    {
        public void Handle(string propery)
        {
            Console.WriteLine($"Persong changed: {propery}");
        }
    }
}
