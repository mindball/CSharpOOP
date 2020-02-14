﻿using System;
using LoggerMart2018.Models.Contracts;

namespace LoggerMart2018.Models
{
    public class Error : IError
    {
        public Error(DateTime dateTime, ErrorLevel level, string message)
        {
            this.DateTime = dateTime;
            this.Level = level;
            this.Message = message;
        }
        public DateTime DateTime { get; }
        public string Message { get; }
        public ErrorLevel Level { get; }
    }
}
