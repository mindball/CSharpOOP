namespace Lectures
{
    using System;
    public class WorkCompletedEventArgs : EventArgs
    {

        public WorkCompletedEventArgs(int hours, WorkType type)
        {
            this.Hours = hours;
            this.WorkType = type;
        }
        public int Hours { get; set; }
        public WorkType WorkType { get; set; }
    }
}
