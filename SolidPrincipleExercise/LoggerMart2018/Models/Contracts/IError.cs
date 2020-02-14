using System;
using System.Collections.Generic;
using System.Text;

namespace LoggerMart2018.Models.Contracts
{
    public interface IError : ILevelError
    {
        DateTime DateTime { get; }

        string Message { get; }
        
    }
}
