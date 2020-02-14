using System;
using System.Collections.Generic;
using System.Linq;
using ExercisesWorkForce.Contracts;

namespace ExercisesWorkForce.Models
{
    public class Job : IJob
    {
        private string name;
        private int jobDoneByHours;
        private ICollection<IEmployee> employes;

        public Job(string name, int jobDoneByHours,
            ICollection<IEmployee> employes)
        {
            this.Name = name;
            this.JobDoneByHours = jobDoneByHours;
            this.employes = employes;

            this.IsDoneJobStatus = false;            
        }

        public IEmployee Employee { get; set; }
        public string Name { get => name; set => name = value; }
        public int JobDoneByHours
        {
            get => jobDoneByHours;
            set
            {
                this.jobDoneByHours = value;
            }
        }

        public bool IsDoneJobStatus { get; private set; }
        public IReadOnlyCollection<IEmployee> Employees => 
            (IReadOnlyCollection<IEmployee>)this.employes;

        public event JobDoneHandlerEvent JobDOne;

        public void AddEmploye(IEmployee employee)
        {
            this.employes.Add(employee);
            this.JobDOne += OnJobDone;
        }

        public void Update()
        {
            foreach (var employee in this.Employees)
            {
                this.JobDoneByHours -= employee.HoursPerWeek;
                if (this.JobDoneByHours <= 0 && !this.IsDoneJobStatus)
                    this.JobDOne.Invoke();
            }
        }

        public void Status()
        {
            if(!this.IsDoneJobStatus)
                Console.WriteLine($"Job: {this.Name} Hours Remaining: {this.JobDoneByHours}");          
        }

        public void OnJobDone()
        {
            this.IsDoneJobStatus = true;
            Console.WriteLine($"Job {this.Name} is done");
        }
    }
}
