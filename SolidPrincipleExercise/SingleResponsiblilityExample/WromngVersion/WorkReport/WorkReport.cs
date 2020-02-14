using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SingleResponsiblilityExample.WromngVersion.WorkReport
{
    public class WorkReport
    {
        private readonly List<WorkReportEntry> _entries;

        public WorkReport()
        {
            _entries = new List<WorkReportEntry>();
        }

        public void AddEntry(WorkReportEntry entry) => _entries.Add(entry);

        public void RemoveEntryAt(int index) => _entries.RemoveAt(index);

        //след време искаме да добавим нов добълнителни ф-сти. и добавяме:
        public void SaveToFile(string directoryPath, string fileName)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), ToString());
        }

        //We can add even more features in this class, 
        //like the Load or UploadToCloud methods because they are all related to our WorkReport,
        //but, just because we can doesn’t mean we have to do it.
        /*
         * В момента има един проблем с класа WorkReport.
            Той носи повече от една отговорност.
            Неговата задача е не само да следи записите на нашия трудов отчет,
            но и да запише целия доклад за работа във файл. 
            Това означава, че нарушаваме SRP и класът ни има повече от
            една причина да се промени в бъдеще.
         **/
            

        public override string ToString() =>
            string.Join(Environment.NewLine, _entries
                .Select(x => $"Code: {x.ProjectCode}," +
                $" Name: {x.ProjectName}," +
                $" Hours: {x.SpentHours}"));

    }
}

