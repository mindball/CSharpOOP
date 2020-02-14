using System;
using System.IO;

namespace LoggerMyversion.Models
{
    using LoggerMyversion.Models.Contracts;
    class MyLogFile : IMyLogFile
    {
        const string DefaultDirectoryPath = "./Data/";

        public MyLogFile(string fileName)
        {
            this.Path = DefaultDirectoryPath + fileName;
            this.Size = 0;
            InitializeFile();
        }

        public int Size { get; private set; }
        public string Path { get; }

        public void WriteMyLogFile(string formattedError)
        {
            File.WriteAllText(this.Path, formattedError);
            int addedSize = 0;
            for (int i = 0; i < formattedError.Length; i++)
            {
                addedSize += formattedError[i];
            }

            this.Size += addedSize;
        }
        private void InitializeFile()
        {
            Directory.CreateDirectory(DefaultDirectoryPath);
            File.WriteAllText(this.Path, "");
        }
    }
}
