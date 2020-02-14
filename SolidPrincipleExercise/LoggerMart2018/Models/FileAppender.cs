using System;
using System.Collections.Generic;
using System.Text;

using LoggerMart2018.Models.Contracts;

namespace LoggerMart2018.Models
{
    public class FileAppender : IAppender
    {
        public ILayout Layout { get; }
        public ErrorLevel Level { get; }

        public void AppendMessage(IError error)
        {
            throw new NotImplementedException();
        }
    }
}
