using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DemoObserver.Models
{
    public class Editor
    {
        private EventManager events;
        private FileStream file;

        public Editor()
        {
            this.events = new EventManager("open", "save");
        }

        public EventManager Events => this.events;

        public void OpenFile(string filePath)
        {
            using (this.file = File.Open(filePath, FileMode.Open))
            {
                this.events.Notify("open", this.file);
            }
        }

        public void SaveFile()
        {
            if (this.file != null)
            {
                events.Notify("save", file);
            }
            else
            {
                throw new Exception("Please open a file first.");
            }
        }
    }
}
