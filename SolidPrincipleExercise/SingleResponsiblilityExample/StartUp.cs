using System;

using wrong = SingleResponsiblilityExample.WromngVersion.EmployeeExample;
using right = SingleResponsiblilityExample.RightVersion.EmployeeExample;
using SingleResponsiblilityExample.RightVersion.WorkReport;


namespace SingleResponsiblilityExample
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Example.1 wrong
            wrong.EmployeeService employeeService = new wrong.EmployeeService
            {
                FirstName = "John",
                LastName = "Deo"
            };
            employeeService.EmployeeRegistration(employeeService);

            //Example.1 right
            right.Employee employee =
                new right.Employee("pesho", "mitkov", "pesho.mitkov@abv.bg");

            right.EmployeeServices.EmployeeService newEmplpoyeeRegistration =
                new right.EmployeeServices.EmployeeService();
            newEmplpoyeeRegistration.RegistrationEmployee(employee);

            //Example.2 right

            var report = new WorkReport();
            report.AddEntry(new WorkReportEntry { ProjectCode = "123Ds", ProjectName = "Project1", SpentHours = 5 });
            report.AddEntry(new WorkReportEntry { ProjectCode = "987Fc", ProjectName = "Project2", SpentHours = 3 });


            var saver = new FileSaver();

            //след тези подобрение може лесно да се добавят нови ф-сти. Например класа ScheduleTask
            var scheduler = new SingleResponsiblilityExample.RightVersion.WorkReport.Schedular();
            scheduler.AddEntry(new ScheduleTask
            { TaskId = 1, Content = "Do something now.", ExecuteOn = DateTime.Now.AddDays(5) });
            scheduler.AddEntry(new ScheduleTask
            { TaskId = 2, Content = "Don't forget to...", ExecuteOn = DateTime.Now.AddDays(2) });

            Console.WriteLine(report.ToString());
            Console.WriteLine(scheduler.ToString());

            saver.SaveToFile(@"Reports", "WorkReport.txt", report);
            saver.SaveToFile(@"Scheduler", "Scheduler.txt", scheduler);

        }
    }
}
