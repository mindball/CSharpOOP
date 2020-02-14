using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerMyversion.Models.Contracts
{
    interface IMyLogFile
    {
        int Size { get; }

        string Path { get; }

        void WriteMyLogFile(string error);
    }
}
