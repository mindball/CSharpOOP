using DemoObserver.Models;
using System;

namespace DemoObserver
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Editor editor = new Editor();
            editor.Events.Subscribe("open", new LogOpenListener("file.txt"));
            editor.Events.Subscribe("save", new EmailNotificationListener("admin@example.com"));

            try
            {
                editor.OpenFile("file.txt");
                editor.SaveFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
