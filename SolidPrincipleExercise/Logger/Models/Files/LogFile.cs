using System;
using System.Globalization;
using System.IO;
using System.Linq;

using Logger.IOManagement;
using Logger.Models.Contracts;
using Logger.Models.Enumeration;

namespace Logger.Models.Files
{
    public class LogFile : IFile
    {
        private const string currentDirectory = @"\logs\";
        private const string currentFile = @"log.txt";
        private const string formatDateTime = @"M/dd/yyyy h:mm:ss tt";

        private string currentPath;
        private IIOManager IOManager;
        public LogFile()
        {
            this.IOManager = new IOManager(currentDirectory, currentFile);
            this.currentPath = this.IOManager.GetCurrentPath();

            this.IOManager.EnsureDirectoryAndFileExist();           
            this.Path = this.currentPath + currentDirectory + currentFile;
        }
        public string Path { get; private set; }
        
        public ulong Size => GetFileSize();


        public string Write(ILayout layout, IError error)
        {
            string format = layout.Format;
            DateTime dateTime = error.DateTime;
            Level level = error.Level;
            string errorMessage = error.Message;

            string formattedMessage = String.Format(format,
                dateTime.ToString(formatDateTime,
                CultureInfo.InvariantCulture),
                level.ToString(),
                errorMessage);

            return formattedMessage;
        }
        private ulong GetFileSize()
        {
            string text = File.ReadAllText(this.Path);

            ulong size = (ulong)text
                .ToCharArray()
                .Where(x => Char.IsLetter(x))
                .Sum(x => (int)x);

            return size;
        }
    }
}
