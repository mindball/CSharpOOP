using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SingleResponsiblilityExample.RightVersion.WorkReport
{
    using SingleResponsiblilityExample.RightVersion.WorkReport.Contracts;

    public class Schedular : IEntryManager<ScheduleTask>
    {
        private readonly List<ScheduleTask> scheduleTask;

        public Schedular()
        {
            scheduleTask = new List<ScheduleTask>();
        }
        public void AddEntry(ScheduleTask entry) => this.scheduleTask.Add(entry);

        public void RemoveEntryAt(int index) => this.scheduleTask.RemoveAt(index);

        public override string ToString() =>
        string.Join(Environment.NewLine,
            scheduleTask.Select(x => $"Task with id: {x.TaskId}" +
            $" with content: {x.Content}" +
            $" is going to be executed on: {x.ExecuteOn}"));
    }
}
