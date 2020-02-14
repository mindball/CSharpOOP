using System;
using System.Collections.Generic;
using System.Text;

namespace Lectures
{
    class EventExample
    {
        /*
         * Events can be members of an interface - Delegates cannot
         * An event can only be called in the class where it is defined
         * By default the access to the events is synchronized (thread-safe)
         * Методите които са свързани с event по конвенция: DoWork() => OnDoWork()
         * class 'ClassName'EventArgs това пак е по конвенция при типовете Args, които ние създаваме
         * */
        public EventExample(int hours, WorkType type)
        {
            Worker newWorker = new Worker();
            newWorker.DoWork(hours, type);
        }
        
    }

    public class Worker
    {
        public delegate void WorkPerformedDelegate(int hours, WorkType type);
        public event WorkPerformedDelegate WorkPerformed;
        public event EventHandler WorkComplete;

        public Worker()
        {
            this.WorkPerformed += OnDoWork;
            this.WorkComplete += OnWorkComplete;
        }

        protected void OnWorkComplete(object sender, EventArgs eventArgs)
        {
            WorkCompletedEventArgs args = eventArgs as WorkCompletedEventArgs;
            Console.WriteLine(args.WorkType + " is done!");
        }

        protected void OnDoWork(int hours, WorkType type)
        {
            Console.WriteLine("Work Performed " + hours);
        }

        public void DoWork(int hours, WorkType type)
        {
            for (int i = 0; i < hours; i++)
            {
                if(this.WorkPerformed != null)
                {
                    this.WorkPerformed.Invoke(i + 1, type);
                }                    
            }

            if (this.WorkComplete != null)
                WorkComplete.Invoke(this, new WorkCompletedEventArgs(hours, type));
        }
    }
}
