using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

class PrintAndWriteIntoFile
{
    FileStream fileName;
    StreamWriter sw;
    public delegate void PrintAndWrite(string str);

    public void PrintMessage(string msg)
    {
        Console.WriteLine(msg);
    }

    public void WriteToFile(string msg)
    {
        fileName = new FileStream(@"D:\message.txt", FileMode.Create, FileAccess.Write);
        sw = new StreamWriter(fileName);
        sw.WriteLine(msg);
        sw.Close();
        fileName.Close();
    }

    public void SendMessage(PrintAndWrite pw)
    {
        pw("Hello world");
    }
}

