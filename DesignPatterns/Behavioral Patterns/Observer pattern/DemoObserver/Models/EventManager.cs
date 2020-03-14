using DemoObserver.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoObserver.Models
{
    public class EventManager
    {
        Dictionary<String, List<IEventListener>> listeners =
            new Dictionary<string, List<IEventListener>>();

        public EventManager(params string[] operations)
        {
            foreach (var operation in operations)
            {
                this.listeners.Add(operation, new List<IEventListener>());
            }
        }

        public void Subscribe(string eventType, IEventListener listener)
        {
            List<IEventListener> users;
            if(!this.listeners.TryGetValue(eventType, out users))
            {
                Console.WriteLine("EventType not found");
            }

            users.Add(listener);
        }

        public void UnSubscribe(string eventType, IEventListener listener)
        {
            List<IEventListener> users;
            if (!this.listeners.TryGetValue(eventType, out users))
            {
                Console.WriteLine("EventType not found");
            }

            users.Remove(listener);
        }

        public void Notify(string eventType, FileStream file)
        {
            List<IEventListener> users;
            if (!this.listeners.TryGetValue(eventType, out users))
            {
                Console.WriteLine("EventType not found");
            }

            foreach (var listener in users)
            {
                listener.Update(eventType, file);
            }
        }
    }
}
