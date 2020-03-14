using DemoObserver.Contracts;
using System;
using System.IO;

namespace DemoObserver.Models
{
    public class LogOpenListener : IEventListener
    {
        private FileStream log;

        public LogOpenListener(string fileName)
        {
            File.Create(fileName).Dispose();
        }
        public void Update(string eventType, FileStream file)
        {
            Console.WriteLine("Save to log " + this.log +
                ": Someone has performed " + eventType +
                " operation with the following file: " + file.Name);
        }
    }
}
