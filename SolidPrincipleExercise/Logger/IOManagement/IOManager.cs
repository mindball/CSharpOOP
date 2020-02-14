using System.IO;

using Logger.Models.Contracts;

namespace Logger.IOManagement
{
    public class IOManager : IIOManager
    {
        private string currentPath;
        private string currentDirectory;
        private string currentFile;

        private IOManager()
        {
            this.currentPath = this.GetCurrentPath();
        }

        public IOManager(string currentDirectory, string currentFile)
        {
            this.currentDirectory = currentDirectory;
            this.currentFile = currentFile;            
        }
        public string CurrentDirectoryPath => this.currentPath + this.currentDirectory;
        public string CurrentFilePath => this.CurrentFilePath + this.currentFile;

        public void EnsureDirectoryAndFileExist()
        {
           if(Directory.Exists(this.CurrentFilePath))
            {
                Directory.CreateDirectory(this.CurrentFilePath);
            }

            File.WriteAllText(CurrentFilePath, "");
        }

        public string GetCurrentPath()
        {
            return Directory.GetCurrentDirectory();
        }
    }
}
