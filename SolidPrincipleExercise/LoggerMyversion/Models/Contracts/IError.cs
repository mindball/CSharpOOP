using System;

namespace LoggerMyversion.Models.Contracts
{
    using LoggerMyversion.Models.Enums;

    public interface IError : ILevelable
    {
        string Message { get; }

        DateTime DateTime { get; }
               
    }
}
