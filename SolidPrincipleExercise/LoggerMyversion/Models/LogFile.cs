using LoggerMyversion.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LoggerMyversion.Models
{
    public class LogFile : ILogFile
    {
        const string DefaultPathDirectory = "./Data/";
        public LogFile(string fileName)
        {
            this.FilePath = DefaultPathDirectory + fileName;
            this.Size = 0;
            InitializeFile();
        }
        public long Size { get; private set; }
        public string FilePath { get; }

        public void WriteToFile(string errorLog)
        {
            File.AppendAllText(this.FilePath, errorLog);

            int addedSize = 0;
            for (int i = 0; i < errorLog.Length; i++)
            {
                addedSize += errorLog[i];
            }

            this.Size += addedSize;
        }

        private void InitializeFile()
        {
            Directory.CreateDirectory(DefaultPathDirectory);
            File.AppendAllText(this.FilePath, "");
        }
    }
}
