using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerMyversion.Models.Contracts
{
    public interface ILogFile
    {
        long Size { get; }

        string FilePath { get; }

        void WriteToFile(string errorLog);

    }
}
