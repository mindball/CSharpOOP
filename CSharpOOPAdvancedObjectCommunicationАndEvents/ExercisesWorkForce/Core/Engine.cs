using ExercisesWorkForce.Contracts;
using ExercisesWorkForce.Factories;
using ExercisesWorkForce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercisesWorkForce.Core
{
    class Engine
    {
        private List<IJob> jobs;
        private EmployeeFactory employeeFactory;
        private IList<IEmployee> newEmployee;
        
        public Engine()
        {
            jobs = new List<IJob>();
            employeeFactory = new EmployeeFactory();
            newEmployee = new List<IEmployee>();
        }
        public void Run()
        {           
            string input = Console.ReadLine();

            while (!input.Equals("End"))
            {
                string[] args = input.Split();
                string command = args[0];

                if(args.Length == 1)
                {
                    foreach (var job in jobs)
                    {
                        job.Status();
                    }
                }
                else if(args.Length == 4)
                {
                    AddNewJob(args);
                }
                else
                {
                    switch (command)
                    {
                        case "PartTimeEmployee":                           
                        case "StandardEmployee":
                            AddNewEmployee(args);
                            break;
                        case "Pass" :
                            PassWeek();
                            break;
                    }
                }
                input = Console.ReadLine();
            }

            

        }

        private void PassWeek()
        {
            foreach (var job in jobs)
            {
                job.Update();
            }
        }

        private void AddNewEmployee(string[] args)
        {
            string typeOfEmployee = args[0];
            string name = args[1];
            newEmployee.Add(employeeFactory.CreateEmployee(typeOfEmployee, name));
        }

        private void AddNewJob(string[] args)
        {
            string jobName = args[1];
            int jobHoursDone = int.Parse(args[2]);
            string employeeName = args[3];

            IEmployee getEmployee = newEmployee.FirstOrDefault(x => x.Name == employeeName);
            IJob newJob = new Job(jobName, jobHoursDone, new List<IEmployee>());
            newJob.AddEmploye(getEmployee);
            jobs.Add(newJob);
            
        }


    }
}
