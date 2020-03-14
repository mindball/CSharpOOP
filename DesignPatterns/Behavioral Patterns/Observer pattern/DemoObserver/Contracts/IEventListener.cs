using System;
using System.IO;

namespace DemoObserver.Contracts
{
    public interface IEventListener
    {
        void Update(String eventType, FileStream file);
    }
}
